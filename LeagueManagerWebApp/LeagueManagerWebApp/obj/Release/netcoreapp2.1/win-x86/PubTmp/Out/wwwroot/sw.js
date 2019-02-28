importScripts('/cache-polyfill.js');

self.addEventListener('install', function (e) {
    e.waitUntil(
        caches.open('site.js').then(function (cache) {
            return cache.addAll([
                '/',
                '/images/back.jpg'
            ]);
        })
    );
});

self.addEventListener('fetch', function (event) {
    console.log(event.request.url);

    event.respondWith(

        caches.match(event.request).then(function (response) {
            return response || fetch(event.request);
        })

    );
});