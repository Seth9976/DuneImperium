using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200011A RID: 282
	public class ListChangedEventArgs : EventArgs
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x0005E270 File Offset: 0x0005C470
		// Note: this type is marked as 'beforefieldinit'.
		static ListChangedEventArgs()
		{
			Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ListChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr);
			ListChangedEventArgs.NativeFieldInfoPtr__ListChangedType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, "<ListChangedType>k__BackingField");
			ListChangedEventArgs.NativeFieldInfoPtr__NewIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, "<NewIndex>k__BackingField");
			ListChangedEventArgs.NativeFieldInfoPtr__OldIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, "<OldIndex>k__BackingField");
			ListChangedEventArgs.NativeFieldInfoPtr__PropertyDescriptor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, "<PropertyDescriptor>k__BackingField");
			ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665815);
			ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665816);
			ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665817);
			ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665818);
			ListChangedEventArgs.NativeMethodInfoPtr_get_ListChangedType_Public_get_ListChangedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665819);
			ListChangedEventArgs.NativeMethodInfoPtr_get_NewIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665820);
			ListChangedEventArgs.NativeMethodInfoPtr_get_OldIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr, 100665821);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0005E37C File Offset: 0x0005C57C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 459429, RefRangeEnd = 459439, XrefRangeStart = 459425, XrefRangeEnd = 459429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listChangedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005E3D4 File Offset: 0x0005C5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459444, RefRangeEnd = 459445, XrefRangeStart = 459439, XrefRangeEnd = 459444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listChangedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0005E43C File Offset: 0x0005C63C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 459450, RefRangeEnd = 459459, XrefRangeStart = 459445, XrefRangeEnd = 459450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listChangedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propDesc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0005E498 File Offset: 0x0005C698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459463, RefRangeEnd = 459464, XrefRangeStart = 459459, XrefRangeEnd = 459463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref listChangedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		public unsafe ListChangedType ListChangedType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr_get_ListChangedType_Public_get_ListChangedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0005E538 File Offset: 0x0005C738
		public unsafe int NewIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr_get_NewIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0005E574 File Offset: 0x0005C774
		public unsafe int OldIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventArgs.NativeMethodInfoPtr_get_OldIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x000081C8 File Offset: 0x000063C8
		public ListChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0005E5B0 File Offset: 0x0005C7B0
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x000081D1 File Offset: 0x000063D1
		public unsafe ListChangedType _ListChangedType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__ListChangedType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__ListChangedType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x0005E5D8 File Offset: 0x0005C7D8
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x000081EC File Offset: 0x000063EC
		public unsafe int _NewIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__NewIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__NewIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0005E600 File Offset: 0x0005C800
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00008207 File Offset: 0x00006407
		public unsafe int _OldIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__OldIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__OldIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0005E628 File Offset: 0x0005C828
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x00008222 File Offset: 0x00006422
		public unsafe PropertyDescriptor _PropertyDescriptor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__PropertyDescriptor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListChangedEventArgs.NativeFieldInfoPtr__PropertyDescriptor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr__ListChangedType_k__BackingField;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr__NewIndex_k__BackingField;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeFieldInfoPtr__OldIndex_k__BackingField;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeFieldInfoPtr__PropertyDescriptor_k__BackingField;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_PropertyDescriptor_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_PropertyDescriptor_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListChangedType_Int32_Int32_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_get_ListChangedType_Public_get_ListChangedType_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_get_NewIndex_Public_get_Int32_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_get_OldIndex_Public_get_Int32_0;
	}
}
