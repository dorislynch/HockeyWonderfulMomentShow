using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Hockey.Wonderful.Moment.Show.RNHockeyWonderfulMomentShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHockeyWonderfulMomentShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHockeyWonderfulMomentShowModule"/>.
        /// </summary>
        internal RNHockeyWonderfulMomentShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHockeyWonderfulMomentShow";
            }
        }
    }
}
