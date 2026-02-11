using System;
using System.Runtime.InteropServices;
using dwd.core.commands;
using dwd.core.data.async;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace lotus.src.data.async
{
	// Token: 0x020000F8 RID: 248
	public class LoadAsyncDataWithLogging : Command
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x0003708C File Offset: 0x0003528C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadAsyncDataWithLogging()
		{
			Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.data.async", "LoadAsyncDataWithLogging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr);
			LoadAsyncDataWithLogging.NativeFieldInfoPtr_logInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "logInterval");
			LoadAsyncDataWithLogging.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "datas");
			LoadAsyncDataWithLogging.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "load");
			LoadAsyncDataWithLogging.NativeFieldInfoPtr_lastLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "lastLog");
			LoadAsyncDataWithLogging.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "sb");
			LoadAsyncDataWithLogging.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppReferenceArray_1_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665200);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_get_Total_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665201);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665202);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665203);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_logIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665204);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_log_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665205);
			LoadAsyncDataWithLogging.NativeMethodInfoPtr_initialized_Private_Boolean_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, 100665206);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000371AC File Offset: 0x000353AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995140, XrefRangeEnd = 995153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadAsyncDataWithLogging(float logInterval, [Optional] Il2CppReferenceArray<IAsyncData> datas)
		{
			if (datas == null)
			{
				datas = new Il2CppReferenceArray<IAsyncData>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logInterval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppReferenceArray_1_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00037214 File Offset: 0x00035414
		public unsafe int Total
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr_get_Total_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00037250 File Offset: 0x00035450
		public unsafe int Remaining
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995153, XrefRangeEnd = 995155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0003728C File Offset: 0x0003548C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995155, XrefRangeEnd = 995160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAsyncDataWithLogging.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000372D8 File Offset: 0x000354D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995160, XrefRangeEnd = 995164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr_logIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0003730C File Offset: 0x0003550C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995207, RefRangeEnd = 995209, XrefRangeStart = 995164, XrefRangeEnd = 995207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void log()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr_log_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00037340 File Offset: 0x00035540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995209, XrefRangeEnd = 995213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool initialized(IAsyncData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging.NativeMethodInfoPtr_initialized_Private_Boolean_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00007838 File Offset: 0x00005A38
		public LoadAsyncDataWithLogging(float logInterval, params IAsyncData[] datas)
			: this(logInterval, new Il2CppReferenceArray<IAsyncData>(datas))
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00007847 File Offset: 0x00005A47
		public LoadAsyncDataWithLogging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00037390 File Offset: 0x00035590
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00007850 File Offset: 0x00005A50
		public unsafe float logInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_logInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_logInterval)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000373B8 File Offset: 0x000355B8
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x0000786B File Offset: 0x00005A6B
		public unsafe HashSet<IAsyncData> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAsyncData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000373E8 File Offset: 0x000355E8
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0000788A File Offset: 0x00005A8A
		public unsafe LoadAsyncData load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadAsyncData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00037418 File Offset: 0x00035618
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000078A9 File Offset: 0x00005AA9
		public unsafe float lastLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_lastLog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_lastLog)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00037440 File Offset: 0x00035640
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000078C4 File Offset: 0x00005AC4
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_logInterval;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeFieldInfoPtr_lastLog;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppReferenceArray_1_IAsyncData_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_Total_Public_get_Int32_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_logIfNeeded_Private_Void_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_log_Private_Void_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_initialized_Private_Boolean_IAsyncData_0;

		// Token: 0x0200024B RID: 587
		[ObfuscatedName("lotus.src.data.async.LoadAsyncDataWithLogging+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06001B35 RID: 6965 RVA: 0x00065168 File Offset: 0x00063368
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadAsyncDataWithLogging>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr);
				LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, "<>1__state");
				LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, "<>2__current");
				LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, "<>4__this");
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665207);
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665208);
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665209);
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665210);
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665211);
				LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr, 100665212);
			}

			// Token: 0x06001B36 RID: 6966 RVA: 0x00065248 File Offset: 0x00063448
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAsyncDataWithLogging._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B37 RID: 6967 RVA: 0x00065290 File Offset: 0x00063490
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B38 RID: 6968 RVA: 0x000652C4 File Offset: 0x000634C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995127, XrefRangeEnd = 995135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00065300 File Offset: 0x00063500
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3A RID: 6970 RVA: 0x00065340 File Offset: 0x00063540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995135, XrefRangeEnd = 995140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00065374 File Offset: 0x00063574
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAsyncDataWithLogging._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B3C RID: 6972 RVA: 0x0000EC40 File Offset: 0x0000CE40
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x06001B3D RID: 6973 RVA: 0x000653B4 File Offset: 0x000635B4
			// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000EC49 File Offset: 0x0000CE49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000653DC File Offset: 0x000635DC
			// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000EC64 File Offset: 0x0000CE64
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0006540C File Offset: 0x0006360C
			// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000EC83 File Offset: 0x0000CE83
			public unsafe LoadAsyncDataWithLogging __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadAsyncDataWithLogging>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAsyncDataWithLogging._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001073 RID: 4211
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001074 RID: 4212
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001075 RID: 4213
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001076 RID: 4214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001077 RID: 4215
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001078 RID: 4216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001079 RID: 4217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400107A RID: 4218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400107B RID: 4219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
