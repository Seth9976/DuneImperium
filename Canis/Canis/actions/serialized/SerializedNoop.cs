using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.serialized
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class SerializedNoop : SerializedAction
	{
		// Token: 0x06001649 RID: 5705 RVA: 0x00072DF8 File Offset: 0x00070FF8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedNoop()
		{
			Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.serialized", "SerializedNoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr);
			SerializedNoop.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr, "Instance");
			SerializedNoop.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr, 100668375);
			SerializedNoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr, 100668376);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00072E64 File Offset: 0x00071064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593303, XrefRangeEnd = 593307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedNoop.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00072EC0 File Offset: 0x000710C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedNoop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedNoop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedNoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0000ABC9 File Offset: 0x00008DC9
		public SerializedNoop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00072EFC File Offset: 0x000710FC
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x0000ABD2 File Offset: 0x00008DD2
		public unsafe static SerializedNoop Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedNoop.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedNoop>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedNoop.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
