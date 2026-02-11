using System;
using Canis.attributes;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.selectionfilters
{
	// Token: 0x02000056 RID: 86
	public class SelectionFilter : Object
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x0002D488 File Offset: 0x0002B688
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionFilter()
		{
			Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SelectionFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr);
			SelectionFilter.NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr, 100664348);
			SelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr, 100664349);
			SelectionFilter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr, 100664350);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		[CallerCount(0)]
		public unsafe virtual bool IsValid(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFilter.NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002D54C File Offset: 0x0002B74C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IAttribute> GetAttributes(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFilter.NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002D5A8 File Offset: 0x0002B7A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFilter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000043DB File Offset: 0x000025DB
		public SelectionFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Abstract_Virtual_New_Boolean_NetworkMessageEvent_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
