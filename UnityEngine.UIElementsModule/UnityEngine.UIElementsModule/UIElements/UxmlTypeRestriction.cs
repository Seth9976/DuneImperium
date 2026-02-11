using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000212 RID: 530
	public class UxmlTypeRestriction : Object
	{
		// Token: 0x06002859 RID: 10329 RVA: 0x000B1480 File Offset: 0x000AF680
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlTypeRestriction()
		{
			Il2CppClassPointerStore<UxmlTypeRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlTypeRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlTypeRestriction>.NativeClassPtr);
			UxmlTypeRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_UxmlTypeRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeRestriction>.NativeClassPtr, 100669353);
			UxmlTypeRestriction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeRestriction>.NativeClassPtr, 100669354);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000B14D8 File Offset: 0x000AF6D8
		[CallerCount(0)]
		public unsafe virtual bool Equals(UxmlTypeRestriction other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTypeRestriction.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_UxmlTypeRestriction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000B1530 File Offset: 0x000AF730
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlTypeRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlTypeRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTypeRestriction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0001048B File Offset: 0x0000E68B
		public UxmlTypeRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C84 RID: 7300
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_UxmlTypeRestriction_0;

		// Token: 0x04001C85 RID: 7301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
