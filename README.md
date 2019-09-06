# README

This is an example of an Unity project with Bugsnag integrated that runs on Android with Proguard enabled, in an exported Gradle project. This has been tested with the default example project generated from:

- Unity5.6.3f1
- Android Studio 3.5.0

`./gradlew assembleRelease` generates an APK that calls `Debug.LogException` when the app is opened, which should be reported to Bugsnag.

`proguard-unity.txt` contains `-keep class com.bugsnag.** { *; }` to retain bugsnag's classes. Without this line, the example project will not report any example errors if proguard is enabled.
