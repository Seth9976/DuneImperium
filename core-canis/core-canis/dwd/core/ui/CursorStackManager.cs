using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.ui
{
	// Token: 0x020000A1 RID: 161
	public class CursorStackManager : MonoBehaviour
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x0003CC24 File Offset: 0x0003AE24
		// Note: this type is marked as 'beforefieldinit'.
		static CursorStackManager()
		{
			Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.ui", "CursorStackManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr);
			CursorStackManager.NativeFieldInfoPtr_defaultCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, "defaultCursor");
			CursorStackManager.NativeFieldInfoPtr_cursorManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, "cursorManager");
			CursorStackManager.NativeFieldInfoPtr_cursorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, "cursorStack");
			CursorStackManager.NativeMethodInfoPtr_get_CurrentCursor_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, 100664809);
			CursorStackManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, 100664810);
			CursorStackManager.NativeMethodInfoPtr_PushCursor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, 100664811);
			CursorStackManager.NativeMethodInfoPtr_PopCursor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, 100664812);
			CursorStackManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr, 100664813);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		public unsafe string CurrentCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorStackManager.NativeMethodInfoPtr_get_CurrentCursor_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003CD2C File Offset: 0x0003AF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863178, XrefRangeEnd = 863189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorStackManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0003CD60 File Offset: 0x0003AF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863197, RefRangeEnd = 863198, XrefRangeStart = 863189, XrefRangeEnd = 863197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushCursor(string cursorName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cursorName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorStackManager.NativeMethodInfoPtr_PushCursor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863222, RefRangeEnd = 863223, XrefRangeStart = 863198, XrefRangeEnd = 863222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopCursor(string cursorName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cursorName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorStackManager.NativeMethodInfoPtr_PopCursor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0003CDE8 File Offset: 0x0003AFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863223, XrefRangeEnd = 863231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CursorStackManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorStackManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorStackManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00005D66 File Offset: 0x00003F66
		public CursorStackManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0003CE24 File Offset: 0x0003B024
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00005D6F File Offset: 0x00003F6F
		public unsafe string defaultCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_defaultCursor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_defaultCursor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0003CE4C File Offset: 0x0003B04C
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00005D8E File Offset: 0x00003F8E
		public unsafe CursorManager cursorManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_cursorManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_cursorManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0003CE7C File Offset: 0x0003B07C
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00005DAD File Offset: 0x00003FAD
		public unsafe List<string> cursorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_cursorStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorStackManager.NativeFieldInfoPtr_cursorStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeFieldInfoPtr_defaultCursor;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_cursorManager;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr_cursorStack;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCursor_Public_get_String_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_PushCursor_Public_Void_String_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_PopCursor_Public_Void_String_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
