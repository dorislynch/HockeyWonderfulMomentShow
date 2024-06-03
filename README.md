
# react-native-hockey-wonderful-moment-show

## Getting started

`$ npm install react-native-hockey-wonderful-moment-show --save`

### Mostly automatic installation

`$ react-native link react-native-hockey-wonderful-moment-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-hockey-wonderful-moment-show` and add `RNHockeyWonderfulMomentShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNHockeyWonderfulMomentShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNHockeyWonderfulMomentShowPackage;` to the imports at the top of the file
  - Add `new RNHockeyWonderfulMomentShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-hockey-wonderful-moment-show'
  	project(':react-native-hockey-wonderful-moment-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-hockey-wonderful-moment-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-hockey-wonderful-moment-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNHockeyWonderfulMomentShow.sln` in `node_modules/react-native-hockey-wonderful-moment-show/windows/RNHockeyWonderfulMomentShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Hockey.Wonderful.Moment.Show.RNHockeyWonderfulMomentShow;` to the usings at the top of the file
  - Add `new RNHockeyWonderfulMomentShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNHockeyWonderfulMomentShow from 'react-native-hockey-wonderful-moment-show';

// TODO: What to do with the module?
RNHockeyWonderfulMomentShow;
```
  