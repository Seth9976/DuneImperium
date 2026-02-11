using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.data.providers
{
	// Token: 0x020001D1 RID: 465
	public class DataProvider : MonoBehaviour
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x0007A540 File Offset: 0x00078740
		// Note: this type is marked as 'beforefieldinit'.
		static DataProvider()
		{
			Il2CppClassPointerStore<DataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.providers", "DataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataProvider>.NativeClassPtr);
			DataProvider.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, "version");
			DataProvider.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, "dirty");
			DataProvider.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, "_Initialized");
			DataProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667387);
			DataProvider.NativeMethodInfoPtr_markDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667388);
			DataProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667389);
			DataProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667390);
			DataProvider.NativeMethodInfoPtr_Get_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667391);
			DataProvider.NativeMethodInfoPtr_Get_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667392);
			DataProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataProvider>.NativeClassPtr, 100667393);
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0007A638 File Offset: 0x00078838
		public unsafe virtual ulong Version
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 881779, RefRangeEnd = 881781, XrefRangeStart = 881779, XrefRangeEnd = 881779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataProvider.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0007A680 File Offset: 0x00078880
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 689957, RefRangeEnd = 689983, XrefRangeStart = 689957, XrefRangeEnd = 689983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void markDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataProvider.NativeMethodInfoPtr_markDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0007A6B4 File Offset: 0x000788B4
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0007A6FC File Offset: 0x000788FC
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0007A748 File Offset: 0x00078948
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 881783, RefRangeEnd = 881788, XrefRangeStart = 881781, XrefRangeEnd = 881783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Get<T>() where T : DataProvider
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataProvider.MethodInfoStoreGeneric_Get_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0007A778 File Offset: 0x00078978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 881790, RefRangeEnd = 881792, XrefRangeStart = 881788, XrefRangeEnd = 881790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Get<T>(out T provider) where T : DataProvider
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref provider;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataProvider.MethodInfoStoreGeneric_Get_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					provider = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0007A7F8 File Offset: 0x000789F8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 881793, RefRangeEnd = 881811, XrefRangeStart = 881792, XrefRangeEnd = 881793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0000B392 File Offset: 0x00009592
		public DataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0007A834 File Offset: 0x00078A34
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000B39B File Offset: 0x0000959B
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0007A85C File Offset: 0x00078A5C
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000B3B6 File Offset: 0x000095B6
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0007A884 File Offset: 0x00078A84
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000B3D1 File Offset: 0x000095D1
		public unsafe bool _Initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr__Initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataProvider.NativeFieldInfoPtr__Initialized)) = value;
			}
		}

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr__Initialized;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_markDirty_Protected_Void_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_T_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Boolean_byref_T_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000366 RID: 870
		private sealed class MethodInfoStoreGeneric_Get_Public_Static_T_0<T>
		{
			// Token: 0x04001AF1 RID: 6897
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataProvider.NativeMethodInfoPtr_Get_Public_Static_T_0, Il2CppClassPointerStore<DataProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000367 RID: 871
		private sealed class MethodInfoStoreGeneric_Get_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x04001AF2 RID: 6898
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataProvider.NativeMethodInfoPtr_Get_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<DataProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
