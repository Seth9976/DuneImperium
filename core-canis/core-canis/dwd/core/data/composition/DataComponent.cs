using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.data.composition
{
	// Token: 0x020001DC RID: 476
	public class DataComponent : Object
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x0007C2B8 File Offset: 0x0007A4B8
		// Note: this type is marked as 'beforefieldinit'.
		static DataComponent()
		{
			Il2CppClassPointerStore<DataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "DataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataComponent>.NativeClassPtr);
			DataComponent.NativeFieldInfoPtr__composition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, "_composition");
			DataComponent.NativeMethodInfoPtr_get_Composition_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667447);
			DataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667448);
			DataComponent.NativeMethodInfoPtr_get_Attached_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667449);
			DataComponent.NativeMethodInfoPtr_Attach_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667450);
			DataComponent.NativeMethodInfoPtr_assertAttached_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667451);
			DataComponent.NativeMethodInfoPtr_warnIfSelf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667452);
			DataComponent.NativeMethodInfoPtr_attaching_Protected_Virtual_New_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667453);
			DataComponent.NativeMethodInfoPtr_GetOne_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667454);
			DataComponent.NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667455);
			DataComponent.NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667456);
			DataComponent.NativeMethodInfoPtr_TryGetOne_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667457);
			DataComponent.NativeMethodInfoPtr_GetMany_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667458);
			DataComponent.NativeMethodInfoPtr_Add_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667459);
			DataComponent.NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667460);
			DataComponent.NativeMethodInfoPtr_Has_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667461);
			DataComponent.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667462);
			DataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataComponent>.NativeClassPtr, 100667463);
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0007C450 File Offset: 0x0007A650
		public unsafe virtual DataComposition Composition
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr_get_Composition_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0007C490 File Offset: 0x0007A690
		[CallerCount(293)]
		[CachedScanResults(RefRangeStart = 881929, RefRangeEnd = 882222, XrefRangeStart = 881929, XrefRangeEnd = 882222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0007C4CC File Offset: 0x0007A6CC
		public unsafe bool Attached
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr_get_Attached_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0007C508 File Offset: 0x0007A708
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 882507, RefRangeEnd = 882511, XrefRangeStart = 882490, XrefRangeEnd = 882507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Attach(DataComposition composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr_Attach_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0007C54C File Offset: 0x0007A74C
		[CallerCount(0)]
		public unsafe void assertAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr_assertAttached_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0007C580 File Offset: 0x0007A780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882511, XrefRangeEnd = 882526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void warnIfSelf<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_warnIfSelf_Private_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0007C5B4 File Offset: 0x0007A7B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void attaching(DataComposition composition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataComponent.NativeMethodInfoPtr_attaching_Protected_Virtual_New_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0007C604 File Offset: 0x0007A804
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 882529, RefRangeEnd = 882575, XrefRangeStart = 882526, XrefRangeEnd = 882529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetOne<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_GetOne_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0007C640 File Offset: 0x0007A840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 882578, RefRangeEnd = 882580, XrefRangeStart = 882575, XrefRangeEnd = 882578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_GetOne_Public_Void_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					retval = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0007C6C0 File Offset: 0x0007A8C0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 882583, RefRangeEnd = 882609, XrefRangeStart = 882580, XrefRangeEnd = 882583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_TryGetOne_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0007C74C File Offset: 0x0007A94C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 882612, RefRangeEnd = 882622, XrefRangeStart = 882609, XrefRangeEnd = 882612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T TryGetOne<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_TryGetOne_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0007C788 File Offset: 0x0007A988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882622, XrefRangeEnd = 882625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetMany<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_GetMany_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0007C7C8 File Offset: 0x0007A9C8
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 882630, RefRangeEnd = 882712, XrefRangeStart = 882625, XrefRangeEnd = 882630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_Add_Public_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0007C848 File Offset: 0x0007AA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882712, XrefRangeEnd = 882714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add([Optional] Il2CppReferenceArray<DataComponent> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<DataComponent>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0007C898 File Offset: 0x0007AA98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 882722, RefRangeEnd = 882723, XrefRangeStart = 882714, XrefRangeEnd = 882722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Has<T>() where T : DataComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataComponent.MethodInfoStoreGeneric_Has_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0007C8D4 File Offset: 0x0007AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882723, XrefRangeEnd = 882727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataComponent.NativeMethodInfoPtr_Clone_Public_Virtual_New_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0007C920 File Offset: 0x0007AB20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 427817, RefRangeEnd = 427822, XrefRangeStart = 427817, XrefRangeEnd = 427822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000B62A File Offset: 0x0000982A
		public void Add(params DataComponent[] components)
		{
			this.Add(new Il2CppReferenceArray<DataComponent>(components));
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000B638 File Offset: 0x00009838
		public DataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0007C964 File Offset: 0x0007AB64
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0000B641 File Offset: 0x00009841
		public unsafe DataComposition _composition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComponent.NativeFieldInfoPtr__composition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataComponent.NativeFieldInfoPtr__composition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr__composition;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_get_Composition_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_get_Attached_Protected_get_Boolean_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_Attach_Public_Void_DataComposition_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_assertAttached_Private_Void_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_warnIfSelf_Private_Void_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_attaching_Protected_Virtual_New_Void_DataComposition_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_GetOne_Public_T_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_TryGetOne_Public_T_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_GetMany_Public_List_1_T_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_T_T_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Il2CppReferenceArray_1_DataComponent_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Boolean_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_DataComponent_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200036B RID: 875
		private sealed class MethodInfoStoreGeneric_warnIfSelf_Private_Void_0<T>
		{
			// Token: 0x04001AF6 RID: 6902
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_warnIfSelf_Private_Void_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200036C RID: 876
		private sealed class MethodInfoStoreGeneric_GetOne_Public_T_0<T>
		{
			// Token: 0x04001AF7 RID: 6903
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_GetOne_Public_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200036D RID: 877
		private sealed class MethodInfoStoreGeneric_GetOne_Public_Void_byref_T_0<T>
		{
			// Token: 0x04001AF8 RID: 6904
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_GetOne_Public_Void_byref_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200036E RID: 878
		private sealed class MethodInfoStoreGeneric_TryGetOne_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04001AF9 RID: 6905
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_TryGetOne_Public_Boolean_byref_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200036F RID: 879
		private sealed class MethodInfoStoreGeneric_TryGetOne_Public_T_0<T>
		{
			// Token: 0x04001AFA RID: 6906
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_TryGetOne_Public_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000370 RID: 880
		private sealed class MethodInfoStoreGeneric_GetMany_Public_List_1_T_0<T>
		{
			// Token: 0x04001AFB RID: 6907
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_GetMany_Public_List_1_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000371 RID: 881
		private sealed class MethodInfoStoreGeneric_Add_Public_T_T_0<T>
		{
			// Token: 0x04001AFC RID: 6908
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_Add_Public_T_T_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000372 RID: 882
		private sealed class MethodInfoStoreGeneric_Has_Public_Boolean_0<T>
		{
			// Token: 0x04001AFD RID: 6909
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DataComponent.NativeMethodInfoPtr_Has_Public_Boolean_0, Il2CppClassPointerStore<DataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
