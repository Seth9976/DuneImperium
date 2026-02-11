using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000226 RID: 550
	public sealed class BatchCullingOutput : ValueType
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x0000E7F2 File Offset: 0x0000C9F2
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingOutput()
		{
			Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr);
			BatchCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, "drawCommands");
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0000E82B File Offset: 0x0000CA2B
		public BatchCullingOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0000E834 File Offset: 0x0000CA34
		public BatchCullingOutput()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr))
		{
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0009DD58 File Offset: 0x0009BF58
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x0000E846 File Offset: 0x0000CA46
		public Unity.Collections.NativeArray<BatchCullingOutputDrawCommands> drawCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands);
				return new Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeFieldInfoPtr_drawCommands;
	}
}
