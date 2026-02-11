using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;

namespace Unity.Profiling
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct ProfilerRecorder
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00018608 File Offset: 0x00016808
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorder()
		{
			Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr);
			ProfilerRecorder.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "handle");
			ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "SharedRecorder");
			ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663372);
			ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663373);
			ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663374);
			ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663375);
			ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663376);
			ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663377);
			ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663378);
			ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663379);
			ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663380);
			ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663381);
			ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663382);
			ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663383);
			ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663384);
			ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663385);
			ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663386);
			ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663387);
			ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663388);
			ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663389);
			ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663390);
			ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663391);
			ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663392);
			ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663393);
			ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663394);
			ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663395);
			ProfilerRecorder.GetValueUnitType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueUnitType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueUnitType_Injected");
			ProfilerRecorder.GetValueDataType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueDataType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueDataType_Injected");
			ProfilerRecorder.GetCurrentValue_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValue_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValue_Injected");
			ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValueAsDouble_Injected");
			ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetLastValueAsDouble_Injected");
			ProfilerRecorder.GetWrapped_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetWrapped_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetWrapped_Injected");
			ProfilerRecorder.CopyTo_List_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_List_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_List_Injected");
			ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_Pointer_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_Pointer_Injected");
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000188B8 File Offset: 0x00016AB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643189, RefRangeEnd = 643193, XrefRangeStart = 643187, XrefRangeEnd = 643189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00018908 File Offset: 0x00016B08
		public unsafe bool Valid
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 643193, RefRangeEnd = 643201, XrefRangeStart = 643193, XrefRangeEnd = 643193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00018938 File Offset: 0x00016B38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643203, RefRangeEnd = 643207, XrefRangeStart = 643201, XrefRangeEnd = 643203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00018960 File Offset: 0x00016B60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 643209, RefRangeEnd = 643213, XrefRangeStart = 643207, XrefRangeEnd = 643209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00018988 File Offset: 0x00016B88
		public unsafe long LastValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 643215, RefRangeEnd = 643217, XrefRangeStart = 643213, XrefRangeEnd = 643215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000189B8 File Offset: 0x00016BB8
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 643219, RefRangeEnd = 643221, XrefRangeStart = 643217, XrefRangeEnd = 643219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000189E8 File Offset: 0x00016BE8
		public unsafe bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 643223, RefRangeEnd = 643224, XrefRangeStart = 643221, XrefRangeEnd = 643223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00018A18 File Offset: 0x00016C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643226, RefRangeEnd = 643228, XrefRangeStart = 643224, XrefRangeEnd = 643226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorderSample GetSample(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00018A58 File Offset: 0x00016C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643228, XrefRangeEnd = 643230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00018AB4 File Offset: 0x00016CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643230, XrefRangeEnd = 643232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Control(ProfilerRecorder handle, ProfilerRecorder.ControlOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00018AF4 File Offset: 0x00016CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643232, XrefRangeEnd = 643234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLastValue(ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00018B34 File Offset: 0x00016D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643234, XrefRangeEnd = 643236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCount(ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00018B80 File Offset: 0x00016D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643236, XrefRangeEnd = 643238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetValid(ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00018BC0 File Offset: 0x00016DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643238, XrefRangeEnd = 643240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRunning(ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00018C00 File Offset: 0x00016E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643240, XrefRangeEnd = 643242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00018C4C File Offset: 0x00016E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643244, RefRangeEnd = 643246, XrefRangeStart = 643242, XrefRangeEnd = 643244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00018C74 File Offset: 0x00016E74
		[CallerCount(0)]
		public unsafe void CheckInitializedAndThrow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00018C9C File Offset: 0x00016E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643246, XrefRangeEnd = 643248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &statHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00018CF8 File Offset: 0x00016EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643248, XrefRangeEnd = 643250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Control_Injected(ref ProfilerRecorder handle, ProfilerRecorder.ControlOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00018D38 File Offset: 0x00016F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643250, XrefRangeEnd = 643252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLastValue_Injected(ref ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00018D78 File Offset: 0x00016F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643252, XrefRangeEnd = 643254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCount_Injected(ref ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643254, XrefRangeEnd = 643256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetValid_Injected(ref ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00018E04 File Offset: 0x00017004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643256, XrefRangeEnd = 643258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRunning_Injected(ref ProfilerRecorder handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00018E44 File Offset: 0x00017044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643258, XrefRangeEnd = 643260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSampleInternal_Injected(ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025FE File Offset: 0x000007FE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00018E94 File Offset: 0x00017094
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002610 File Offset: 0x00000810
		public unsafe static ProfilerRecorderOptions SharedRecorder
		{
			get
			{
				ProfilerRecorderOptions profilerRecorderOptions;
				IL2CPP.il2cpp_field_static_get_value(ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder, (void*)(&profilerRecorderOptions));
				return profilerRecorderOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder, (void*)(&value));
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00018EB0 File Offset: 0x000170B0
		public unsafe static ProfilerRecorder StartNew(ProfilerCategory category, string statName, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
		{
			char* ptr = statName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return new ProfilerRecorder(category, ptr, statName.Length, capacity, options | ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00018EE4 File Offset: 0x000170E4
		public static ProfilerRecorder StartNew(ProfilerMarker marker, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
		{
			return new ProfilerRecorder(marker, capacity, options | ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00018F00 File Offset: 0x00017100
		public static ProfilerRecorder StartNew()
		{
			return ProfilerRecorder.Create(default(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), 0, ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00018F24 File Offset: 0x00017124
		public Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetValueDataType(this);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00018F48 File Offset: 0x00017148
		public ProfilerMarkerDataUnit UnitType
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetValueUnitType(this);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000261E File Offset: 0x0000081E
		public void Reset()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.Reset);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00018F6C File Offset: 0x0001716C
		public long CurrentValue
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCurrentValue(this);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00018F90 File Offset: 0x00017190
		public double CurrentValueAsDouble
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCurrentValueAsDouble(this);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00018FB4 File Offset: 0x000171B4
		public double LastValueAsDouble
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetLastValueAsDouble(this);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00018FD8 File Offset: 0x000171D8
		public int Capacity
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCount(this, ProfilerRecorder.CountOptions.MaxCount);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00019000 File Offset: 0x00017200
		public bool WrappedAround
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetWrapped(this);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00019024 File Offset: 0x00017224
		public void CopyTo(List<ProfilerRecorderSample> outSamples, [Optional] bool reset)
		{
			bool flag = outSamples == null;
			if (flag)
			{
				throw new ArgumentNullException("outSamples");
			}
			this.CheckInitializedAndThrow();
			ProfilerRecorder.CopyTo_List(this, outSamples, reset);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001905C File Offset: 0x0001725C
		public unsafe int CopyTo(ProfilerRecorderSample* dest, int destSize, [Optional] bool reset)
		{
			this.CheckInitializedWithParamsAndThrow(dest);
			return ProfilerRecorder.CopyTo_Pointer(this, dest, destSize, reset);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002635 File Offset: 0x00000835
		public Il2CppStructArray<ProfilerRecorderSample> ToArray()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002642 File Offset: 0x00000842
		public void FilterToCurrentThread()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetFilterToCurrentThread);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002659 File Offset: 0x00000859
		public void CollectFromAllThreads()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetToCollectFromAllThreads);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002670 File Offset: 0x00000870
		public static ProfilerMarkerDataUnit GetValueUnitType(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueUnitType_Injected(ref handle);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002679 File Offset: 0x00000879
		public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueDataType_Injected(ref handle);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002682 File Offset: 0x00000882
		public static long GetCurrentValue(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValue_Injected(ref handle);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000268B File Offset: 0x0000088B
		public static double GetCurrentValueAsDouble(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValueAsDouble_Injected(ref handle);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002694 File Offset: 0x00000894
		public static double GetLastValueAsDouble(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetLastValueAsDouble_Injected(ref handle);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000269D File Offset: 0x0000089D
		public static bool GetWrapped(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetWrapped_Injected(ref handle);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000026A6 File Offset: 0x000008A6
		public static void CopyTo_List(ProfilerRecorder handle, List<ProfilerRecorderSample> outSamples, bool reset)
		{
			ProfilerRecorder.CopyTo_List_Injected(ref handle, outSamples, reset);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000026B1 File Offset: 0x000008B1
		public unsafe static int CopyTo_Pointer(ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
		{
			return ProfilerRecorder.CopyTo_Pointer_Injected(ref handle, outSamples, outSamplesSize, reset);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00019084 File Offset: 0x00017284
		public unsafe void CheckInitializedWithParamsAndThrow(ProfilerRecorderSample* dest)
		{
			bool flag = this.handle == 0UL;
			if (flag)
			{
				throw new InvalidOperationException("ProfilerRecorder object is not initialized or has been disposed.");
			}
			bool flag2 = dest == null;
			if (flag2)
			{
				throw new ArgumentNullException("dest");
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000026BD File Offset: 0x000008BD
		public static ProfilerMarkerDataUnit GetValueUnitType_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueUnitType_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000026CA File Offset: 0x000008CA
		public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueDataType_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000026D7 File Offset: 0x000008D7
		public static long GetCurrentValue_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValue_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000026E4 File Offset: 0x000008E4
		public static double GetCurrentValueAsDouble_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000026F1 File Offset: 0x000008F1
		public static double GetLastValueAsDouble_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000026FE File Offset: 0x000008FE
		public static bool GetWrapped_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetWrapped_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000270B File Offset: 0x0000090B
		public static void CopyTo_List_Injected(ref ProfilerRecorder handle, List<ProfilerRecorderSample> outSamples, bool reset)
		{
			ProfilerRecorder.CopyTo_List_InjectedDelegateField(ref handle, IL2CPP.Il2CppObjectBaseToPtr(outSamples), reset);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe static int CopyTo_Pointer_Injected(ref ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
		{
			return ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField(ref handle, outSamples, outSamplesSize, reset);
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_SharedRecorder;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0;

		// Token: 0x040000B3 RID: 179
		[FieldOffset(0)]
		public ulong handle;

		// Token: 0x040000B4 RID: 180
		private static readonly ProfilerRecorder.GetValueUnitType_InjectedDelegate GetValueUnitType_InjectedDelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly ProfilerRecorder.GetValueDataType_InjectedDelegate GetValueDataType_InjectedDelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly ProfilerRecorder.GetCurrentValue_InjectedDelegate GetCurrentValue_InjectedDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate GetCurrentValueAsDouble_InjectedDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate GetLastValueAsDouble_InjectedDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly ProfilerRecorder.GetWrapped_InjectedDelegate GetWrapped_InjectedDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly ProfilerRecorder.CopyTo_List_InjectedDelegate CopyTo_List_InjectedDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly ProfilerRecorder.CopyTo_Pointer_InjectedDelegate CopyTo_Pointer_InjectedDelegateField;

		// Token: 0x02000399 RID: 921
		public enum ControlOptions
		{
			// Token: 0x04002AD3 RID: 10963
			Start,
			// Token: 0x04002AD4 RID: 10964
			Stop,
			// Token: 0x04002AD5 RID: 10965
			Reset,
			// Token: 0x04002AD6 RID: 10966
			Release = 4,
			// Token: 0x04002AD7 RID: 10967
			SetFilterToCurrentThread,
			// Token: 0x04002AD8 RID: 10968
			SetToCollectFromAllThreads
		}

		// Token: 0x0200039A RID: 922
		public enum CountOptions
		{
			// Token: 0x04002ADA RID: 10970
			Count,
			// Token: 0x04002ADB RID: 10971
			MaxCount
		}

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x06003011 RID: 12305
		private delegate ProfilerMarkerDataUnit GetValueUnitType_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x06003013 RID: 12307
		private delegate Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x06003015 RID: 12309
		private delegate long GetCurrentValue_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039E RID: 926
		// (Invoke) Token: 0x06003017 RID: 12311
		private delegate double GetCurrentValueAsDouble_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039F RID: 927
		// (Invoke) Token: 0x06003019 RID: 12313
		private delegate double GetLastValueAsDouble_InjectedDelegate(IntPtr handle);

		// Token: 0x020003A0 RID: 928
		// (Invoke) Token: 0x0600301B RID: 12315
		private delegate bool GetWrapped_InjectedDelegate(IntPtr handle);

		// Token: 0x020003A1 RID: 929
		// (Invoke) Token: 0x0600301D RID: 12317
		private delegate void CopyTo_List_InjectedDelegate(IntPtr handle, IntPtr outSamples, bool reset);

		// Token: 0x020003A2 RID: 930
		// (Invoke) Token: 0x0600301F RID: 12319
		private delegate int CopyTo_Pointer_InjectedDelegate(IntPtr handle, IntPtr outSamples, int outSamplesSize, bool reset);
	}
}
