document.addEventListener('DOMContentLoaded', function() {
    // Обработчики кликов для элементов списка
    document.querySelectorAll('.deposit-item').forEach(item => {
        item.addEventListener('click', function(e) {
            // Если клик по элементу, который не должен вести на детальную страницу
            if (e.target.classList.contains('no-navigate')) {
                e.preventDefault();
                return;
            }

            const id = this.getAttribute('data-id');
            const deposit = depositsData[id];

            if (!deposit) return;

            // Подсветка в списке
            document.querySelectorAll('.deposit-item').forEach(i =>
                i.classList.remove('active'));
            this.classList.add('active');

            // Отправка данных в iframe (если нужно)
            const iframe = document.getElementById('yandex-map');
            if (iframe) {
                iframe.contentWindow.postMessage({
                    action: 'highlightFeature',
                    coords: deposit.coords,
                    name: deposit.fname || deposit.location
                }, '*');
            }

        });
    });

    // Обработчики для точек на карте
    document.querySelectorAll('.deposit-point').forEach(point => {
        point.addEventListener('click', function(e) {
            e.stopPropagation();
            const id = this.getAttribute('data-id');
            const correspondingItem = document.querySelector(`.deposit-item[data-id="${id}"]`);

            if (correspondingItem) {
                // Имитируем клик по элементу списка
                correspondingItem.click();

                // Прокручиваем к элементу
                correspondingItem.scrollIntoView({
                    behavior: 'smooth',
                    block: 'nearest'
                });
            }
        });
    });
    // Подсветка соответствующей точки при наведении на элемент списка
    document.querySelectorAll('.license-item').forEach(item => {
        item.addEventListener('mouseenter', function() {
            const licenseId = this.dataset.id;
            document.querySelector(`.deposit-point[data-id="${licenseId}"]`).classList.add('hover');
        });

        item.addEventListener('mouseleave', function() {
            const licenseId = this.dataset.id;
            document.querySelector(`.deposit-point[data-id="${licenseId}"]`).classList.remove('hover');
        });
    });
});