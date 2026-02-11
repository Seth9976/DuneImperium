using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000128 RID: 296
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x06001792 RID: 6034 RVA: 0x0006FD74 File Offset: 0x0006DF74
		// Note: this type is marked as 'beforefieldinit'.
		static ContextMenu()
		{
			Il2CppClassPointerStore<ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ContextMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr);
			ContextMenu.NativeFieldInfoPtr_menuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "menuItem");
			ContextMenu.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "validate");
			ContextMenu.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, "priority");
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100666522);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100666523);
			ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100666524);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0006FE1C File Offset: 0x0006E01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660732, XrefRangeEnd = 660734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0006FE68 File Offset: 0x0006E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660734, XrefRangeEnd = 660736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660736, XrefRangeEnd = 660738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenu(string itemName, bool isValidateFunction, int priority)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isValidateFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000094D0 File Offset: 0x000076D0
		public ContextMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0006FF2C File Offset: 0x0006E12C
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x000094D9 File Offset: 0x000076D9
		public unsafe string menuItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0006FF54 File Offset: 0x0006E154
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x000094F8 File Offset: 0x000076F8
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006FF7C File Offset: 0x0006E17C
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x00009513 File Offset: 0x00007713
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr_menuItem;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0;
	}
}
