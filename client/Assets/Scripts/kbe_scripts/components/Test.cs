namespace KBEngine
	{
		using UnityEngine; 
		using System; 
		using System.Collections; 
		using System.Collections.Generic;

		public class Test : TestBase
		{
			public Test() : base()
			{
			}

			public override void onAttached(Entity ownerEntity) {
				Dbg.DEBUG_MSG("Test::onAttached: ownerEntity(" + ownerEntity.id + ")!");
			}
			
			public override void onDetached(Entity ownerEntity) {
				Dbg.DEBUG_MSG("Test::onDetached: ownerEntity(" + ownerEntity.id + ")!");
			}

			public override void onOwnChanged(Int32 oldValue) {
				Dbg.DEBUG_MSG("Test::onOwnChanged: own(" + own + ")!");
			}

			public override void onStateChanged(Int32 oldValue) {
				Dbg.DEBUG_MSG("Test::onOwnChanged: state(" + state + ")!");
			}

			public override void helloCB(Int32 arg1)
			{
			    Dbg.DEBUG_MSG("Test::helloCB: arg1(" + arg1 + ")!");

				//if(cellEntityCall)
                //	cellEntityCall.hello(795);
			}
		}
	} 
