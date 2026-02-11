using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001CD RID: 461
	[StructLayout(2)]
	public struct Update
	{
		// Token: 0x060020FA RID: 8442 RVA: 0x0000C91F File Offset: 0x0000AB1F
		// Note: this type is marked as 'beforefieldinit'.
		static Update()
		{
			Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Update");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0000C944 File Offset: 0x0000AB44
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, ref this));
		}

		// Token: 0x020008D7 RID: 2263
		[StructLayout(2)]
		public struct ScriptRunBehaviourUpdate
		{
			// Token: 0x06003AAB RID: 15019 RVA: 0x00015602 File Offset: 0x00013802
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunBehaviourUpdate()
			{
				Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunBehaviourUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AAC RID: 15020 RVA: 0x00015622 File Offset: 0x00013822
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunBehaviourUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D8 RID: 2264
		[StructLayout(2)]
		public struct DirectorUpdate
		{
			// Token: 0x06003AAD RID: 15021 RVA: 0x00015634 File Offset: 0x00013834
			// Note: this type is marked as 'beforefieldinit'.
			static DirectorUpdate()
			{
				Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "DirectorUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AAE RID: 15022 RVA: 0x00015654 File Offset: 0x00013854
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.DirectorUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D9 RID: 2265
		[StructLayout(2)]
		public struct ScriptRunDelayedDynamicFrameRate
		{
			// Token: 0x06003AAF RID: 15023 RVA: 0x00015666 File Offset: 0x00013866
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedDynamicFrameRate()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedDynamicFrameRate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
			}

			// Token: 0x06003AB0 RID: 15024 RVA: 0x00015686 File Offset: 0x00013886
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008DA RID: 2266
		[StructLayout(2)]
		public struct ScriptRunDelayedTasks
		{
			// Token: 0x06003AB1 RID: 15025 RVA: 0x00015698 File Offset: 0x00013898
			// Note: this type is marked as 'beforefieldinit'.
			static ScriptRunDelayedTasks()
			{
				Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedTasks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr);
			}

			// Token: 0x06003AB2 RID: 15026 RVA: 0x000156B8 File Offset: 0x000138B8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update.ScriptRunDelayedTasks>.NativeClassPtr, ref this));
			}
		}
	}
}
