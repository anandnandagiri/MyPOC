


// Install the service worker
self.addEventListener('install', function (event) {
    event.waitUntil(
        caches.open('offline-cache').then(function (cache) {
            return cache.addAll([
                'index.html', // Add other HTML files here
                'styles.css', // Add CSS files here
                'script.js', // Add JavaScript files here
                @@@CacheFiles
                // Add other static assets like images, fonts, etc.
            ]);
        })
    );
});

// Serve cached files when offline
self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request).then(function (response) {
            return response || fetch(event.request);
        })
    );
});


//Service Worker Sync data once online
self.addEventListener('sync', function (event) {
    if (event.tag === 'sync-data') {
        event.waitUntil(syncData());
    }
});

function syncData() {
    return fetch('/api/data')
        .then(function (response) {
            return response.json();
        })
        .then(function (data) {
            // Process the retrieved data
            console.log('Data synchronized:', data);
        });
}



// Service Worker push notification
self.addEventListener('push', function (event) {
    const title = 'My Web App';
    const options = {
        body: event.data.text(),
        icon: '/notification-icon.png',
        badge: '/notification-badge.png'
    };

    event.waitUntil(
        self.registration.showNotification(title, options)
    );
});


//Service Worker unique registration scope
if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('/sw.js')
        .then(function (registration) {
            const scope = registration.scope;
            console.log('Service Worker registration scope:', scope);
        })
        .catch(function (error) {
            console.log('Service Worker registration failed:', error);
        });
}


//const userAgent = navigator.userAgent;
//console.log('User Agent:', userAgent);

// Check if the internet connection is available
function checkInternetConnection() {
return navigator.onLine;
}

// Redirect to the offline.html page if the internet connection is not available
function redirectOffline() {
    window.location.href = 'offline.html';
}

// Check the internet connection status on page load
window.addEventListener('load', function() {
if (!checkInternetConnection()) {
    redirectOffline();
}
});

// Check the internet connection status when the user goes offline or online
window.addEventListener('online', function() {
    redirectOffline();
});

window.addEventListener('offline', function() {
    redirectOffline();
});

