using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Serializable]
public class PackedPlayModeBuildLogs : global::Il2CppSystem.Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x000047F0 File Offset: 0x000029F0
	// Note: this type is marked as 'beforefieldinit'.
	static PackedPlayModeBuildLogs()
	{
		Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "", "PackedPlayModeBuildLogs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr);
		PackedPlayModeBuildLogs.NativeFieldInfoPtr_m_RuntimeBuildLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr, "m_RuntimeBuildLogs");
		PackedPlayModeBuildLogs.NativeMethodInfoPtr_get_RuntimeBuildLogs_Public_get_List_1_RuntimeBuildLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr, 100663297);
		PackedPlayModeBuildLogs.NativeMethodInfoPtr_set_RuntimeBuildLogs_Public_set_Void_List_1_RuntimeBuildLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr, 100663298);
		PackedPlayModeBuildLogs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr, 100663299);
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00004870 File Offset: 0x00002A70
	// (set) Token: 0x06000003 RID: 3 RVA: 0x000048B0 File Offset: 0x00002AB0
	public unsafe List<PackedPlayModeBuildLogs.RuntimeBuildLog> RuntimeBuildLogs
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackedPlayModeBuildLogs.NativeMethodInfoPtr_get_RuntimeBuildLogs_Public_get_List_1_RuntimeBuildLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PackedPlayModeBuildLogs.RuntimeBuildLog>>(intPtr3) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackedPlayModeBuildLogs.NativeMethodInfoPtr_set_RuntimeBuildLogs_Public_set_Void_List_1_RuntimeBuildLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000048F4 File Offset: 0x00002AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157685, XrefRangeEnd = 1157693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackedPlayModeBuildLogs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackedPlayModeBuildLogs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	public PackedPlayModeBuildLogs(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x00004930 File Offset: 0x00002B30
	// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.NativeFieldInfoPtr_m_RuntimeBuildLogs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackedPlayModeBuildLogs.RuntimeBuildLog>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.NativeFieldInfoPtr_m_RuntimeBuildLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeBuildLogs;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeBuildLogs_Public_get_List_1_RuntimeBuildLog_0;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_set_RuntimeBuildLogs_Public_set_Void_List_1_RuntimeBuildLog_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200002B RID: 43
	[Serializable]
	public sealed class RuntimeBuildLog : ValueType
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0001348C File Offset: 0x0001168C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeBuildLog()
		{
			Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackedPlayModeBuildLogs>.NativeClassPtr, "RuntimeBuildLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr);
			PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr, "Type");
			PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr, "Message");
			PackedPlayModeBuildLogs.RuntimeBuildLog.NativeMethodInfoPtr__ctor_Public_Void_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000134F4 File Offset: 0x000116F4
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeBuildLog(LogType type, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackedPlayModeBuildLogs.RuntimeBuildLog.NativeMethodInfoPtr__ctor_Public_Void_LogType_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000032FB File Offset: 0x000014FB
		public RuntimeBuildLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003304 File Offset: 0x00001504
		public RuntimeBuildLog()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackedPlayModeBuildLogs.RuntimeBuildLog>.NativeClassPtr))
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00013554 File Offset: 0x00011754
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00003316 File Offset: 0x00001516
		public unsafe LogType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0001357C File Offset: 0x0001177C
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00003331 File Offset: 0x00001531
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackedPlayModeBuildLogs.RuntimeBuildLog.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogType_String_0;
	}
}
