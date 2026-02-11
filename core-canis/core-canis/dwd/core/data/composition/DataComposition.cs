using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.data.composition
{
	// Token: 0x020001DD RID: 477
	public sealed class DataComposition : Object
	{
		// Token: 0x06001A49 RID: 6729 RVA: 0x0007C994 File Offset: 0x0007AB94
		// Note: this type is marked as 'beforefieldinit'.
		static DataComposition()
		{
			Il2CppClassPointerStore<DataComposition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "DataComposition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataComposition>.NativeClassPtr);
			DataComposition.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, "components");
			DataComposition.NativeFieldInfoPtr_sourceComposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, "sourceComposition");
			DataComposition.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667464);
			DataComposition.NativeMethodInfoPtr__ctor_Public_Void_IList_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667465);
			DataComposition.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667466);
			DataComposition.NativeMethodInfoPtr__ctor_Private_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667467);
			DataComposition.NativeMethodInfoPtr__ctor_Private_Void_List_1_DataComponent_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667468);
			DataComposition.NativeMethodInfoPtr_get_Item_Public_get_DataComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667469);
			DataComposition.NativeMethodInfoPtr_Reserve_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667470);
			DataComposition.NativeMethodInfoPtr_Add_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667471);
			DataComposition.NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667472);
			DataComposition.NativeMethodInfoPtr_Add_Public_Void_IList_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667473);
			DataComposition.NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667474);
			DataComposition.NativeMethodInfoPtr_GetOne_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667475);
			DataComposition.NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667476);
			DataComposition.NativeMethodInfoPtr_TryGetOne_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667477);
			DataComposition.NativeMethodInfoPtr_GetMany_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667478);
			DataComposition.NativeMethodInfoPtr_Has_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667479);
			DataComposition.NativeMethodInfoPtr_Clone_Public_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667480);
			DataComposition.NativeMethodInfoPtr_ShallowClone_Public_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667481);
			DataComposition.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667482);
			DataComposition.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667483);
			DataComposition.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComposition>.NativeClassPtr, 100667484);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0007CB90 File Offset: 0x0007AD90
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 882741, RefRangeEnd = 882877, XrefRangeStart = 882727, XrefRangeEnd = 882741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition([Optional] Il2CppReferenceArray<DataComponent> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<DataComponent>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComposition>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0007CBE8 File Offset: 0x0007ADE8
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 882741, RefRangeEnd = 882877, XrefRangeStart = 882741, XrefRangeEnd = 882877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition(IList<DataComponent> components)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComposition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr__ctor_Public_Void_IList_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0007CC34 File Offset: 0x0007AE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882877, XrefRangeEnd = 882886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComposition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0007CC7C File Offset: 0x0007AE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 882905, RefRangeEnd = 882906, XrefRangeStart = 882886, XrefRangeEnd = 882905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition(DataComposition other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComposition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr__ctor_Private_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0007CCC8 File Offset: 0x0007AEC8
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition(List<DataComponent> components, DataComposition sourceComposition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComposition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceComposition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr__ctor_Private_Void_List_1_DataComponent_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000740 RID: 1856
		public unsafe DataComponent this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882906, XrefRangeEnd = 882910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_get_Item_Public_get_DataComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0007CD74 File Offset: 0x0007AF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882910, XrefRangeEnd = 882916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reserve(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_Reserve_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		[CallerCount(194)]
		[CachedScanResults(RefRangeStart = 882920, RefRangeEnd = 883114, XrefRangeStart = 882916, XrefRangeEnd = 882920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Add<T>(T component) where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = component;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref component;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_Add_Public_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0007CE34 File Offset: 0x0007B034
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 883115, RefRangeEnd = 883124, XrefRangeStart = 883114, XrefRangeEnd = 883115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add([Optional] Il2CppReferenceArray<DataComponent> newComponents)
		{
			if (newComponents == null)
			{
				newComponents = new Il2CppReferenceArray<DataComponent>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newComponents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0007CE84 File Offset: 0x0007B084
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 883146, RefRangeEnd = 883151, XrefRangeStart = 883124, XrefRangeEnd = 883146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(IList<DataComponent> newComponents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newComponents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_Add_Public_Void_IList_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 883153, RefRangeEnd = 883154, XrefRangeStart = 883151, XrefRangeEnd = 883153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOne<T>(out T retval) where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
					intPtr2 = ref retval;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_GetOne_Public_Void_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					retval = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0007CF48 File Offset: 0x0007B148
		[CallerCount(222)]
		[CachedScanResults(RefRangeStart = 883156, RefRangeEnd = 883378, XrefRangeStart = 883154, XrefRangeEnd = 883156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOne<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_GetOne_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0007CF84 File Offset: 0x0007B184
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 883392, RefRangeEnd = 883480, XrefRangeStart = 883378, XrefRangeEnd = 883392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetOne<T>(out T component) where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
					intPtr2 = ref component;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_TryGetOne_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0007D010 File Offset: 0x0007B210
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 883482, RefRangeEnd = 883502, XrefRangeStart = 883480, XrefRangeEnd = 883482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T TryGetOne<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_TryGetOne_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0007D04C File Offset: 0x0007B24C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 883515, RefRangeEnd = 883520, XrefRangeStart = 883502, XrefRangeEnd = 883515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetMany<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_GetMany_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007D08C File Offset: 0x0007B28C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 883527, RefRangeEnd = 883530, XrefRangeStart = 883520, XrefRangeEnd = 883527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Has<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.MethodInfoStoreGeneric_Has_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007D0C8 File Offset: 0x0007B2C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 883534, RefRangeEnd = 883539, XrefRangeStart = 883530, XrefRangeEnd = 883534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_Clone_Public_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0007D108 File Offset: 0x0007B308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883539, XrefRangeEnd = 883545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition ShallowClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_ShallowClone_Public_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0007D148 File Offset: 0x0007B348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883545, XrefRangeEnd = 883548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DataComponent>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new List<DataComponent>.Enumerator(intPtr);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007D180 File Offset: 0x0007B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883548, XrefRangeEnd = 883554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<DataComponent> System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007D1C0 File Offset: 0x0007B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883554, XrefRangeEnd = 883560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComposition.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0000B660 File Offset: 0x00009860
		public DataComposition(params DataComponent[] components)
			: this(new Il2CppReferenceArray<DataComponent>(components))
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000B66E File Offset: 0x0000986E
		public void Add(params DataComponent[] newComponents)
		{
			this.Add(new Il2CppReferenceArray<DataComponent>(newComponents));
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0000B67C File Offset: 0x0000987C
		public DataComposition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0007D200 File Offset: 0x0007B400
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000B685 File Offset: 0x00009885
		public unsafe List<DataComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComposition.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComposition.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0007D230 File Offset: 0x0007B430
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public unsafe DataComposition sourceComposition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComposition.NativeFieldInfoPtr_sourceComposition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComposition.NativeFieldInfoPtr_sourceComposition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_sourceComposition;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DataComponent_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_DataComponent_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_DataComposition_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_List_1_DataComponent_DataComposition_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataComponent_Int32_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_Reserve_Public_Void_Int32_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_T_T_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_IList_1_DataComponent_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_GetOne_Public_T_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOne_Public_T_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_GetMany_Public_List_1_T_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Boolean_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_DataComposition_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_ShallowClone_Public_DataComposition_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_DataComponent_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000373 RID: 883
		private sealed class MethodInfoStoreGeneric_Add_Public_T_T_0<T>
		{
			// Token: 0x04001AFE RID: 6910
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_Add_Public_T_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000374 RID: 884
		private sealed class MethodInfoStoreGeneric_GetOne_Public_Void_byref_T_0<T>
		{
			// Token: 0x04001AFF RID: 6911
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000375 RID: 885
		private sealed class MethodInfoStoreGeneric_GetOne_Public_T_0<T>
		{
			// Token: 0x04001B00 RID: 6912
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_GetOne_Public_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000376 RID: 886
		private sealed class MethodInfoStoreGeneric_TryGetOne_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04001B01 RID: 6913
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000377 RID: 887
		private sealed class MethodInfoStoreGeneric_TryGetOne_Public_T_0<T>
		{
			// Token: 0x04001B02 RID: 6914
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_TryGetOne_Public_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000378 RID: 888
		private sealed class MethodInfoStoreGeneric_GetMany_Public_List_1_T_0<T>
		{
			// Token: 0x04001B03 RID: 6915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_GetMany_Public_List_1_T_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000379 RID: 889
		private sealed class MethodInfoStoreGeneric_Has_Public_Boolean_0<T>
		{
			// Token: 0x04001B04 RID: 6916
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComposition.NativeMethodInfoPtr_Has_Public_Boolean_0, Il2CppClassPointerStore<DataComposition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
