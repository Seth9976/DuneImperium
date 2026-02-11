using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x0200008F RID: 143
	public class LogAutoOpen : MonoBehaviour
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x0003A4F0 File Offset: 0x000386F0
		// Note: this type is marked as 'beforefieldinit'.
		static LogAutoOpen()
		{
			Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "LogAutoOpen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr);
			LogAutoOpen.NativeFieldInfoPtr_autoSuppressDevelopmentBuildConsole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, "autoSuppressDevelopmentBuildConsole");
			LogAutoOpen.NativeFieldInfoPtr_openParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, "openParam");
			LogAutoOpen.NativeFieldInfoPtr_openControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, "openControl");
			LogAutoOpen.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, "dispatcher");
			LogAutoOpen.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, 100664712);
			LogAutoOpen.NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, 100664713);
			LogAutoOpen.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, 100664714);
			LogAutoOpen.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, 100664715);
			LogAutoOpen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr, 100664716);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0003A5D4 File Offset: 0x000387D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862606, XrefRangeEnd = 862614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLog(string logString, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpen.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0003A638 File Offset: 0x00038838
		public unsafe virtual bool shouldOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862614, XrefRangeEnd = 862619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogAutoOpen.NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0003A680 File Offset: 0x00038880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862619, XrefRangeEnd = 862646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpen.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0003A6B4 File Offset: 0x000388B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862646, XrefRangeEnd = 862660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpen.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0003A6E8 File Offset: 0x000388E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 862665, RefRangeEnd = 862666, XrefRangeStart = 862660, XrefRangeEnd = 862665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogAutoOpen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogAutoOpen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAutoOpen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00005993 File Offset: 0x00003B93
		public LogAutoOpen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0003A724 File Offset: 0x00038924
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0000599C File Offset: 0x00003B9C
		public unsafe bool autoSuppressDevelopmentBuildConsole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_autoSuppressDevelopmentBuildConsole);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_autoSuppressDevelopmentBuildConsole)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0003A74C File Offset: 0x0003894C
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000059B7 File Offset: 0x00003BB7
		public unsafe string openParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_openParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_openParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0003A774 File Offset: 0x00038974
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x000059D6 File Offset: 0x00003BD6
		public unsafe IDebugLogOpenControl openControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_openControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDebugLogOpenControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_openControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0003A7A4 File Offset: 0x000389A4
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x000059F5 File Offset: 0x00003BF5
		public unsafe LogDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAutoOpen.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_autoSuppressDevelopmentBuildConsole;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_openParam;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_openControl;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldOpen_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
