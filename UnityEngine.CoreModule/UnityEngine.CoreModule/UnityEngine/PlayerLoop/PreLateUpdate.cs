using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001CE RID: 462
	[StructLayout(2)]
	public struct PreLateUpdate
	{
		// Token: 0x060020FC RID: 8444 RVA: 0x0000C956 File Offset: 0x0000AB56
		// Note: this type is marked as 'beforefieldinit'.
		static PreLateUpdate()
		{
			Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0000C97B File Offset: 0x0000AB7B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008DB RID: 2267
		[StructLayout(2)]
		public struct Physics2DLateUpdate
		{
			// Token: 0x06003AB3 RID: 15027 RVA: 0x000156CA File Offset: 0x000138CA
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "Physics2DLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AB4 RID: 15028 RVA: 0x000156EA File Offset: 0x000138EA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.Physics2DLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DC RID: 2268
		[StructLayout(2)]
		public struct PhysicsLateUpdate
		{
			// Token: 0x06003AB5 RID: 15029 RVA: 0x000156FC File Offset: 0x000138FC
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.PhysicsLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "PhysicsLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.PhysicsLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AB6 RID: 15030 RVA: 0x0001571C File Offset: 0x0001391C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.PhysicsLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DD RID: 2269
		[StructLayout(2)]
		public struct AIUpdatePostScript
		{
			// Token: 0x06003AB7 RID: 15031 RVA: 0x0001572E File Offset: 0x0001392E
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdatePostScript()
			{
				Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "AIUpdatePostScript");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr);
			}

			// Token: 0x06003AB8 RID: 15032 RVA: 0x0001574E File Offset: 0x0001394E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.AIUpdatePostScript>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DE RID: 2270
		[StructLayout(2)]
		public struct DirectorUpdateAnimationBegin
		{
			// Token: 0x06003AB9 RID: 15033 RVA: 0x00015760 File Offset: 0x00013960
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationBegin()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationBegin");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr);
			}

			// Token: 0x06003ABA RID: 15034 RVA: 0x00015780 File Offset: 0x00013980
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationBegin>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DF RID: 2271
		[StructLayout(2)]
		public struct LegacyAnimationUpdate
		{
			// Token: 0x06003ABB RID: 15035 RVA: 0x00015792 File Offset: 0x00013992
			// Note: this type is marked as 'beforefieldinit'.
			static LegacyAnimationUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "LegacyAnimationUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr);
			}

			// Token: 0x06003ABC RID: 15036 RVA: 0x000157B2 File Offset: 0x000139B2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.LegacyAnimationUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E0 RID: 2272
		[StructLayout(2)]
		public struct DirectorUpdateAnimationEnd
		{
			// Token: 0x06003ABD RID: 15037 RVA: 0x000157C4 File Offset: 0x000139C4
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdateAnimationEnd()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationEnd");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr);
			}

			// Token: 0x06003ABE RID: 15038 RVA: 0x000157E4 File Offset: 0x000139E4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorUpdateAnimationEnd>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E1 RID: 2273
		[StructLayout(2)]
		public struct DirectorDeferredEvaluate
		{
			// Token: 0x06003ABF RID: 15039 RVA: 0x000157F6 File Offset: 0x000139F6
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorDeferredEvaluate()
			{
				Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorDeferredEvaluate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr);
			}

			// Token: 0x06003AC0 RID: 15040 RVA: 0x00015816 File Offset: 0x00013A16
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.DirectorDeferredEvaluate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E2 RID: 2274
		[StructLayout(2)]
		public struct UIElementsUpdatePanels
		{
			// Token: 0x06003AC1 RID: 15041 RVA: 0x00015828 File Offset: 0x00013A28
			// Note: this type is marked as 'beforefieldinit'.
			static UIElementsUpdatePanels()
			{
				Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UIElementsUpdatePanels");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr);
			}

			// Token: 0x06003AC2 RID: 15042 RVA: 0x00015848 File Offset: 0x00013A48
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UIElementsUpdatePanels>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E3 RID: 2275
		[StructLayout(2)]
		public struct UpdateNetworkManager
		{
			// Token: 0x06003AC3 RID: 15043 RVA: 0x0001585A File Offset: 0x00013A5A
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateNetworkManager()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateNetworkManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr);
			}

			// Token: 0x06003AC4 RID: 15044 RVA: 0x0001587A File Offset: 0x00013A7A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateNetworkManager>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E4 RID: 2276
		[StructLayout(2)]
		public struct UpdateMasterServerInterface
		{
			// Token: 0x06003AC5 RID: 15045 RVA: 0x0001588C File Offset: 0x00013A8C
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMasterServerInterface()
			{
				Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateMasterServerInterface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr);
			}

			// Token: 0x06003AC6 RID: 15046 RVA: 0x000158AC File Offset: 0x00013AAC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.UpdateMasterServerInterface>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E5 RID: 2277
		[StructLayout(2)]
		public struct EndGraphicsJobsAfterScriptUpdate
		{
			// Token: 0x06003AC7 RID: 15047 RVA: 0x000158BE File Offset: 0x00013ABE
			// Note: this type is marked as 'beforefieldinit'.
			static EndGraphicsJobsAfterScriptUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "EndGraphicsJobsAfterScriptUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AC8 RID: 15048 RVA: 0x000158DE File Offset: 0x00013ADE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E6 RID: 2278
		[StructLayout(2)]
		public struct ParticleSystemBeginUpdateAll
		{
			// Token: 0x06003AC9 RID: 15049 RVA: 0x000158F0 File Offset: 0x00013AF0
			// Note: this type is marked as 'beforefieldinit'.
			static ParticleSystemBeginUpdateAll()
			{
				Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ParticleSystemBeginUpdateAll");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr);
			}

			// Token: 0x06003ACA RID: 15050 RVA: 0x00015910 File Offset: 0x00013B10
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ParticleSystemBeginUpdateAll>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E7 RID: 2279
		[StructLayout(2)]
		public struct ScriptRunBehaviourLateUpdate
		{
			// Token: 0x06003ACB RID: 15051 RVA: 0x00015922 File Offset: 0x00013B22
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourLateUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ScriptRunBehaviourLateUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr);
			}

			// Token: 0x06003ACC RID: 15052 RVA: 0x00015942 File Offset: 0x00013B42
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ScriptRunBehaviourLateUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008E8 RID: 2280
		[StructLayout(2)]
		public struct ConstraintManagerUpdate
		{
			// Token: 0x06003ACD RID: 15053 RVA: 0x00015954 File Offset: 0x00013B54
			// Note: this type is marked as 'beforefieldinit'.
			static ConstraintManagerUpdate()
			{
				Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ConstraintManagerUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr);
			}

			// Token: 0x06003ACE RID: 15054 RVA: 0x00015974 File Offset: 0x00013B74
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate.ConstraintManagerUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
