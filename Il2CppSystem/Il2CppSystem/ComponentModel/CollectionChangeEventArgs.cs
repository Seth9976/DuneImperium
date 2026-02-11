using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000FD RID: 253
	public class CollectionChangeEventArgs : EventArgs
	{
		// Token: 0x06001003 RID: 4099 RVA: 0x00058774 File Offset: 0x00056974
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionChangeEventArgs()
		{
			Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "CollectionChangeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr);
			CollectionChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr, "<Action>k__BackingField");
			CollectionChangeEventArgs.NativeFieldInfoPtr__Element_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr, "<Element>k__BackingField");
			CollectionChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_CollectionChangeAction_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr, 100665603);
			CollectionChangeEventArgs.NativeMethodInfoPtr_get_Action_Public_Virtual_New_get_CollectionChangeAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr, 100665604);
			CollectionChangeEventArgs.NativeMethodInfoPtr_get_Element_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr, 100665605);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00058808 File Offset: 0x00056A08
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 456734, RefRangeEnd = 456751, XrefRangeStart = 456729, XrefRangeEnd = 456734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionChangeEventArgs(CollectionChangeAction action, Object element)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionChangeEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_CollectionChangeAction_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00058864 File Offset: 0x00056A64
		public unsafe virtual CollectionChangeAction Action
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionChangeEventArgs.NativeMethodInfoPtr_get_Action_Public_Virtual_New_get_CollectionChangeAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x000588AC File Offset: 0x00056AAC
		public unsafe virtual Object Element
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionChangeEventArgs.NativeMethodInfoPtr_get_Element_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public CollectionChangeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x000588F8 File Offset: 0x00056AF8
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00007C01 File Offset: 0x00005E01
		public unsafe CollectionChangeAction _Action_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionChangeEventArgs.NativeFieldInfoPtr__Action_k__BackingField)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00058920 File Offset: 0x00056B20
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x00007C1C File Offset: 0x00005E1C
		public unsafe Object _Element_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionChangeEventArgs.NativeFieldInfoPtr__Element_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionChangeEventArgs.NativeFieldInfoPtr__Element_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeFieldInfoPtr__Action_k__BackingField;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr__Element_k__BackingField;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CollectionChangeAction_Object_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_Virtual_New_get_CollectionChangeAction_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_get_Element_Public_Virtual_New_get_Object_0;
	}
}
