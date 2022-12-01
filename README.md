# FlyoutScrollingKeyboardBug
This reproduces a Xamarin.Forms bug with scrollable flyout content and the iOS keyboard.
This happens when you have flyout content with a scrollview. Opening the iOS keyboard (when flyout closed) causes 
the flyout content to render over the header an it gets stuck there.

This only happens to iOS not on android

To Reproduce:
1. Deploy the app to an iphone
2. Tap on the entry text box on the displayed page
3. Open the flyout
-> notice that the flyout content is now rendered over the header.

# This is what the flyout looks like before opening the iOS keyboard

![Flyout before opening keyboard](FlyoutBeforeIosKeyboard.PNG?raw=true "Flyout before opening iOS keyboard")

# This is what the flyout looks like after opening the iOS keyboard

![Flyout after opening keyboard](FlyoutAfterIosKeyboard.PNG?raw=true "Flyout after opening iOS keyboard")
