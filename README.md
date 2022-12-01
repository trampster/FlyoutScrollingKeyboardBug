# FlyoutScrollingKeyboardBug
This reproduces a Xamarin.Forms bug with scrollable flyout content and the iOS keyboard.
This happens when you have flyout content with a scrollview. Opening the iOS keyboard (when flyout closed) causes 
the flyout content to render over the header an it gets stuck there.

To Reproduce:
1. Deploy the app to an iphone
2. Tap on the entry text box on the displayed page
3. Open the flyout
-> notice that the flyout content is now rendered over the header.
