namespace KBEngine
{
	using UnityEngine; 
	using System; 
	using System.Collections; 
	using System.Collections.Generic;

	public class TestNoBase : TestNoBaseBase
	{
		public TestNoBase() : base()
		{

		}

		public override void onAttached(Entity ownerEntity)
		{
			Dbg.DEBUG_MSG("TestNoBase::onAttached: ownerEntity(" + ownerEntity.id + ")!");
		}
			
		public override void onDetached(Entity ownerEntity) 
		{
			Dbg.DEBUG_MSG("TestNoBase::onDetached: ownerEntity(" + ownerEntity.id + ")!");
		}

		public override void onOwnChanged(Int32 oldValue) 
		{
			Dbg.DEBUG_MSG("Test::onOwnChanged: own(" + own + ")!");
		}
		public override void onStateChanged(Int32 oldValue) 
		{
			Dbg.DEBUG_MSG("Test::onOwnChanged: state(" + state + ")!");
		}

		public override void helloCB(Int32 arg1)
		{
		    Dbg.DEBUG_MSG("TestNoBase::helloCB: arg1(" + arg1 + ")!");
			if(((Avatar)owner).cellEntityCall != null)
        		((Avatar)owner).cellEntityCall.component3.hello(795);
		}
	}
} 
