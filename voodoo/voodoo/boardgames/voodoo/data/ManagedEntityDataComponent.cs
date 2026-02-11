using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using lotus;

namespace boardgames.voodoo.data
{
	// Token: 0x020000A4 RID: 164
	public class ManagedEntityDataComponent : ManagedDataComponent
	{
		// Token: 0x0600096C RID: 2412 RVA: 0x00028CB0 File Offset: 0x00026EB0
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedEntityDataComponent()
		{
			Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo.data", "ManagedEntityDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr);
			ManagedEntityDataComponent.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, "data");
			ManagedEntityDataComponent.NativeFieldInfoPtr_dirtyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, "dirtyNode");
			ManagedEntityDataComponent.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664666);
			ManagedEntityDataComponent.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664667);
			ManagedEntityDataComponent.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664668);
			ManagedEntityDataComponent.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664669);
			ManagedEntityDataComponent.NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664670);
			ManagedEntityDataComponent.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr, 100664671);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00028D80 File Offset: 0x00026F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117401, RefRangeEnd = 1117402, XrefRangeStart = 1117381, XrefRangeEnd = 1117401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagedEntityDataComponent(EntityComponent data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedEntityDataComponent.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00028DCC File Offset: 0x00026FCC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagedEntityDataComponent.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00028E08 File Offset: 0x00027008
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00028E48 File Offset: 0x00027048
		public unsafe virtual LinkedListNode<IAmDirty> DirtyNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117402, XrefRangeEnd = 1117409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedEntityDataComponent.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedEntityDataComponent.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00028E8C File Offset: 0x0002708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117409, XrefRangeEnd = 1117422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagedEntityDataComponent.NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00028EC8 File Offset: 0x000270C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117422, XrefRangeEnd = 1117441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProperty<T>(ref T currentValue, T newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ManagedEntityDataComponent.MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000693D File Offset: 0x00004B3D
		public ManagedEntityDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00028F6C File Offset: 0x0002716C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00006946 File Offset: 0x00004B46
		public unsafe EntityComponent data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedEntityDataComponent.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedEntityDataComponent.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00028F9C File Offset: 0x0002719C
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00006965 File Offset: 0x00004B65
		public unsafe LinkedListNode<IAmDirty> dirtyNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedEntityDataComponent.NativeFieldInfoPtr_dirtyNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagedEntityDataComponent.NativeFieldInfoPtr_dirtyNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_dirtyNode;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0;

		// Token: 0x02000119 RID: 281
		private sealed class MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>
		{
			// Token: 0x0400090B RID: 2315
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ManagedEntityDataComponent.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0, Il2CppClassPointerStore<ManagedEntityDataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
