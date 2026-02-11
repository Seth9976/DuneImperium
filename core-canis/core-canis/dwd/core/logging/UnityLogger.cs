using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.logging
{
	// Token: 0x02000176 RID: 374
	public class UnityLogger : global::Il2CppSystem.Object
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x00069D1C File Offset: 0x00067F1C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityLogger()
		{
			Il2CppClassPointerStore<UnityLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.logging", "UnityLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr);
			UnityLogger.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, "Instance");
			UnityLogger.NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, 100666534);
			UnityLogger.NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, 100666535);
			UnityLogger.NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, 100666536);
			UnityLogger.NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, 100666537);
			UnityLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr, 100666538);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00069DC4 File Offset: 0x00067FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876309, XrefRangeEnd = 876313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_logging_ILogger_Log(LogType level, string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogger.NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00069E14 File Offset: 0x00068014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876313, XrefRangeEnd = 876321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_logging_ILogger_Log(LogType level, string s, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogger.NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00069E84 File Offset: 0x00068084
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 876338, RefRangeEnd = 876341, XrefRangeStart = 876321, XrefRangeEnd = 876338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(LogType level, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogger.NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00069EC8 File Offset: 0x000680C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876346, RefRangeEnd = 876347, XrefRangeStart = 876341, XrefRangeEnd = 876346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(LogType level, string s, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogger.NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00069F2C File Offset: 0x0006812C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityLogger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityLogger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000097A6 File Offset: 0x000079A6
		public virtual void dwd_core_logging_ILogger_Log(LogType level, string s, params global::Il2CppSystem.Object[] args)
		{
			this.dwd_core_logging_ILogger_Log(level, s, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000097B6 File Offset: 0x000079B6
		public static void Log(LogType level, string s, params global::Il2CppSystem.Object[] args)
		{
			UnityLogger.Log(level, s, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000097C5 File Offset: 0x000079C5
		public UnityLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00069F68 File Offset: 0x00068168
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x000097CE File Offset: 0x000079CE
		public unsafe static UnityLogger Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityLogger.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityLogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityLogger.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_logging_ILogger_Log_Private_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
