using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D9 RID: 217
	public class IEntryOverride : Il2CppObjectBase
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x00006973 File Offset: 0x00004B73
		// Note: this type is marked as 'beforefieldinit'.
		static IEntryOverride()
		{
			Il2CppClassPointerStore<IEntryOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "IEntryOverride");
			IEntryOverride.NativeMethodInfoPtr_GetOverride_Public_Abstract_Virtual_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntryOverride>.NativeClassPtr, 100665129);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00032D58 File Offset: 0x00030F58
		[CallerCount(0)]
		public unsafe virtual EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntryOverride.NativeMethodInfoPtr_GetOverride_Public_Abstract_Virtual_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			tableReference = ((intPtr5 == 0) ? null : new TableReference(intPtr5));
			IntPtr intPtr6 = intPtr2;
			tableEntryReference = ((intPtr6 == 0) ? null : new TableEntryReference(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000069A2 File Offset: 0x00004BA2
		public IEntryOverride(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_GetOverride_Public_Abstract_Virtual_New_EntryOverrideType_byref_TableReference_byref_TableEntryReference_0;
	}
}
