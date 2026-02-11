using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003A RID: 58
	public class ContextualMenuManager : Object
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x0002E934 File Offset: 0x0002CB34
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualMenuManager()
		{
			Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextualMenuManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr);
			ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, "<displayMenuHandledOSX>k__BackingField");
			ContextualMenuManager.NativeMethodInfoPtr_get_displayMenuHandledOSX_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663966);
			ContextualMenuManager.NativeMethodInfoPtr_set_displayMenuHandledOSX_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663967);
			ContextualMenuManager.NativeMethodInfoPtr_DisplayMenuIfEventMatches_Public_Abstract_Virtual_New_Void_EventBase_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663968);
			ContextualMenuManager.NativeMethodInfoPtr_DisplayMenu_Public_Void_EventBase_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663969);
			ContextualMenuManager.NativeMethodInfoPtr_DoDisplayMenu_FamOrAssem_Abstract_Virtual_New_Void_DropdownMenu_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663970);
			ContextualMenuManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr, 100663971);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x0002EA2C File Offset: 0x0002CC2C
		public unsafe bool displayMenuHandledOSX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManager.NativeMethodInfoPtr_get_displayMenuHandledOSX_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManager.NativeMethodInfoPtr_set_displayMenuHandledOSX_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		[CallerCount(0)]
		public unsafe virtual void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuManager.NativeMethodInfoPtr_DisplayMenuIfEventMatches_Public_Abstract_Virtual_New_Void_EventBase_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0002EACC File Offset: 0x0002CCCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288124, RefRangeEnd = 288125, XrefRangeStart = 288084, XrefRangeEnd = 288124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayMenu(EventBase triggerEvent, IEventHandler target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManager.NativeMethodInfoPtr_DisplayMenu_Public_Void_EventBase_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0002EB20 File Offset: 0x0002CD20
		[CallerCount(0)]
		public unsafe virtual void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(menu);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuManager.NativeMethodInfoPtr_DoDisplayMenu_FamOrAssem_Abstract_Virtual_New_Void_DropdownMenu_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0002EB80 File Offset: 0x0002CD80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualMenuManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualMenuManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003551 File Offset: 0x00001751
		public ContextualMenuManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x0000355A File Offset: 0x0000175A
		public unsafe bool _displayMenuHandledOSX_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManager.NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField)) = value;
			}
		}

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr__displayMenuHandledOSX_k__BackingField;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_get_displayMenuHandledOSX_Internal_get_Boolean_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_set_displayMenuHandledOSX_Internal_set_Void_Boolean_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMenuIfEventMatches_Public_Abstract_Virtual_New_Void_EventBase_IEventHandler_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMenu_Public_Void_EventBase_IEventHandler_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_DoDisplayMenu_FamOrAssem_Abstract_Virtual_New_Void_DropdownMenu_EventBase_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
