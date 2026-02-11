using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004AB RID: 1195
	public class EventSource : Object
	{
		// Token: 0x060049F2 RID: 18930 RVA: 0x00156498 File Offset: 0x00154698
		// Note: this type is marked as 'beforefieldinit'.
		static EventSource()
		{
			Il2CppClassPointerStore<EventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource>.NativeClassPtr);
			EventSource.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "<Name>k__BackingField");
			EventSource.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "<Settings>k__BackingField");
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674050);
			EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674051);
			EventSource.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674052);
			EventSource.NativeMethodInfoPtr__ctor_Internal_Void_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674053);
			EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674054);
			EventSource.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674055);
			EventSource.NativeMethodInfoPtr_set_Settings_Private_set_Void_EventSourceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674056);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674057);
			EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674058);
			EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674059);
			EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674060);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674061);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674062);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674063);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674064);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674065);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674066);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674067);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674068);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674069);
			EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674070);
			EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource>.NativeClassPtr, 100674071);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x001566A8 File Offset: 0x001548A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1414587, RefRangeEnd = 1414591, XrefRangeStart = 1414583, XrefRangeEnd = 1414587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x001566E4 File Offset: 0x001548E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414594, RefRangeEnd = 1414595, XrefRangeStart = 1414591, XrefRangeEnd = 1414594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(EventSourceSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x0015672C File Offset: 0x0015492C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(string eventSourceName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventSourceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x00156778 File Offset: 0x00154978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414597, RefRangeEnd = 1414598, XrefRangeStart = 1414595, XrefRangeEnd = 1414597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSource(Guid eventSourceGuid, string eventSourceName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventSourceGuid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventSourceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr__ctor_Internal_Void_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001567D4 File Offset: 0x001549D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012EE RID: 4846
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x00156810 File Offset: 0x00154A10
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012EF RID: 4847
		// (set) Token: 0x060049F9 RID: 18937 RVA: 0x00156854 File Offset: 0x00154A54
		public unsafe EventSourceSettings Settings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_set_Settings_Private_set_Void_EventSourceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00156894 File Offset: 0x00154A94
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001568D0 File Offset: 0x00154AD0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00156928 File Offset: 0x00154B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414598, XrefRangeEnd = 1414602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x0015695C File Offset: 0x00154B5C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x001569A8 File Offset: 0x00154BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414610, RefRangeEnd = 1414611, XrefRangeStart = 1414602, XrefRangeEnd = 1414610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, int arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x001569F4 File Offset: 0x00154BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414620, RefRangeEnd = 1414621, XrefRangeStart = 1414611, XrefRangeEnd = 1414620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00156A44 File Offset: 0x00154C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414633, RefRangeEnd = 1414634, XrefRangeStart = 1414621, XrefRangeEnd = 1414633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, int arg1, int arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00156AA0 File Offset: 0x00154CA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1414650, RefRangeEnd = 1414654, XrefRangeStart = 1414634, XrefRangeEnd = 1414650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00156B08 File Offset: 0x00154D08
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1414662, RefRangeEnd = 1414678, XrefRangeStart = 1414654, XrefRangeEnd = 1414662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, long arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00156B54 File Offset: 0x00154D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414688, RefRangeEnd = 1414689, XrefRangeStart = 1414678, XrefRangeEnd = 1414688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, long arg1, string arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00156BB4 File Offset: 0x00154DB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00156C14 File Offset: 0x00154E14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1414699, RefRangeEnd = 1414704, XrefRangeStart = 1414689, XrefRangeEnd = 1414699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, int arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00156C74 File Offset: 0x00154E74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1414718, RefRangeEnd = 1414721, XrefRangeStart = 1414704, XrefRangeEnd = 1414718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, int arg2, int arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00156CE0 File Offset: 0x00154EE0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1414738, RefRangeEnd = 1414752, XrefRangeStart = 1414721, XrefRangeEnd = 1414738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00156D58 File Offset: 0x00154F58
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventDataCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x0001B184 File Offset: 0x00019384
		public void WriteEvent(int eventId, params Object[] args)
		{
			this.WriteEvent(eventId, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x0001B193 File Offset: 0x00019393
		public EventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x00156DB4 File Offset: 0x00154FB4
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x0001B19C File Offset: 0x0001939C
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00156DDC File Offset: 0x00154FDC
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0001B1BB File Offset: 0x000193BB
		public unsafe EventSourceSettings _Settings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr__Settings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSource.NativeFieldInfoPtr__Settings_k__BackingField)) = value;
			}
		}

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeFieldInfoPtr__Settings_k__BackingField;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_EventSourceSettings_0;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Guid_String_0;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeMethodInfoPtr_set_Settings_Private_set_Void_EventSourceSettings_0;

		// Token: 0x04003CAA RID: 15530
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

		// Token: 0x04003CAB RID: 15531
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_EventLevel_EventKeywords_0;

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_0;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_0;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_0;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_0;

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Int64_String_0;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_0;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_Int32_Int32_0;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeMethodInfoPtr_WriteEvent_Protected_Void_Int32_String_String_String_0;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeMethodInfoPtr_WriteEventCore_Protected_Void_Int32_Int32_ptr_EventData_0;

		// Token: 0x020006DF RID: 1759
		[StructLayout(2)]
		public struct EventData
		{
			// Token: 0x06005D62 RID: 23906 RVA: 0x001A67C4 File Offset: 0x001A49C4
			// Note: this type is marked as 'beforefieldinit'.
			static EventData()
			{
				Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSource>.NativeClassPtr, "EventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr);
				EventSource.EventData.NativeFieldInfoPtr__DataPointer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "<DataPointer>k__BackingField");
				EventSource.EventData.NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "<Size>k__BackingField");
				EventSource.EventData.NativeFieldInfoPtr__Reserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, "<Reserved>k__BackingField");
				EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674072);
				EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674073);
				EventSource.EventData.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, 100674074);
			}

			// Token: 0x170017EB RID: 6123
			// (set) Token: 0x06005D63 RID: 23907 RVA: 0x001A6868 File Offset: 0x001A4A68
			public unsafe IntPtr DataPointer
			{
				[CallerCount(44)]
				[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170017EC RID: 6124
			// (set) Token: 0x06005D64 RID: 23908 RVA: 0x001A689C File Offset: 0x001A4A9C
			public unsafe int Size
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170017ED RID: 6125
			// (set) Token: 0x06005D65 RID: 23909 RVA: 0x001A68D0 File Offset: 0x001A4AD0
			public unsafe int Reserved
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSource.EventData.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005D66 RID: 23910 RVA: 0x000221E3 File Offset: 0x000203E3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSource.EventData>.NativeClassPtr, ref this));
			}

			// Token: 0x04004C2D RID: 19501
			private static readonly IntPtr NativeFieldInfoPtr__DataPointer_k__BackingField;

			// Token: 0x04004C2E RID: 19502
			private static readonly IntPtr NativeFieldInfoPtr__Size_k__BackingField;

			// Token: 0x04004C2F RID: 19503
			private static readonly IntPtr NativeFieldInfoPtr__Reserved_k__BackingField;

			// Token: 0x04004C30 RID: 19504
			private static readonly IntPtr NativeMethodInfoPtr_set_DataPointer_Public_set_Void_IntPtr_0;

			// Token: 0x04004C31 RID: 19505
			private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0;

			// Token: 0x04004C32 RID: 19506
			private static readonly IntPtr NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Int32_0;

			// Token: 0x04004C33 RID: 19507
			[FieldOffset(0)]
			public IntPtr _DataPointer_k__BackingField;

			// Token: 0x04004C34 RID: 19508
			[FieldOffset(8)]
			public int _Size_k__BackingField;

			// Token: 0x04004C35 RID: 19509
			[FieldOffset(12)]
			public int _Reserved_k__BackingField;
		}
	}
}
