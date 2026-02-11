using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.composition
{
	// Token: 0x020001E1 RID: 481
	public class ListLookup<T> : VersionedDataComponent
	{
		// Token: 0x06001A77 RID: 6775 RVA: 0x0007D648 File Offset: 0x0007B848
		// Note: this type is marked as 'beforefieldinit'.
		static ListLookup()
		{
			Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "ListLookup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr);
			ListLookup<T>.NativeMethodInfoPtr_get_List_Public_get_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr, 100667496);
			ListLookup<T>.NativeMethodInfoPtr_get_list_Protected_Abstract_Virtual_New_get_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr, 100667497);
			ListLookup<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr, 100667498);
			ListLookup<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr, 100667499);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0007D704 File Offset: 0x0007B904
		public unsafe IList<T> List
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListLookup<T>.NativeMethodInfoPtr_get_List_Public_get_IList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x0007D744 File Offset: 0x0007B944
		public unsafe virtual IList<T> list
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListLookup<T>.NativeMethodInfoPtr_get_list_Protected_Abstract_Virtual_New_get_IList_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0007D790 File Offset: 0x0007B990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883683, XrefRangeEnd = 883714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListLookup<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x0007D7D4 File Offset: 0x0007B9D4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 499944, RefRangeEnd = 499953, XrefRangeStart = 499944, XrefRangeEnd = 499953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListLookup<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListLookup<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0000B70D File Offset: 0x0000990D
		public ListLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Public_get_IList_1_T_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_get_list_Protected_Abstract_Virtual_New_get_IList_1_T_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
