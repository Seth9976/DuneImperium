using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000AE RID: 174
	public class SteamServerStats : SteamServerClass<SteamServerStats>
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x0004C08C File Offset: 0x0004A28C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServerStats()
		{
			Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamServerStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr);
			SteamServerStats.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServerStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665934);
			SteamServerStats.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665935);
			SteamServerStats.NativeMethodInfoPtr_RequestUserStatsAsync_Public_Static_Task_1_Result_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665936);
			SteamServerStats.NativeMethodInfoPtr_SetInt_Public_Static_Boolean_SteamId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665937);
			SteamServerStats.NativeMethodInfoPtr_SetFloat_Public_Static_Boolean_SteamId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665938);
			SteamServerStats.NativeMethodInfoPtr_GetInt_Public_Static_Int32_SteamId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665939);
			SteamServerStats.NativeMethodInfoPtr_GetFloat_Public_Static_Single_SteamId_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665940);
			SteamServerStats.NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665941);
			SteamServerStats.NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665942);
			SteamServerStats.NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_SteamId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665943);
			SteamServerStats.NativeMethodInfoPtr_StoreUserStats_Public_Static_Task_1_Result_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665944);
			SteamServerStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, 100665945);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0004C1AC File Offset: 0x0004A3AC
		public unsafe static ISteamGameServerStats Internal
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 943195, RefRangeEnd = 943204, XrefRangeStart = 943192, XrefRangeEnd = 943195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServerStats_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamGameServerStats>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943204, XrefRangeEnd = 943208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamServerStats.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0004C22C File Offset: 0x0004A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943208, XrefRangeEnd = 943221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Result> RequestUserStatsAsync(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_RequestUserStatsAsync_Public_Static_Task_1_Result_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Result>>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0004C26C File Offset: 0x0004A46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943221, XrefRangeEnd = 943223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetInt(SteamId steamid, string name, int stat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_SetInt_Public_Static_Boolean_SteamId_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943223, XrefRangeEnd = 943225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetFloat(SteamId steamid, string name, float stat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_SetFloat_Public_Static_Boolean_SteamId_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0004C32C File Offset: 0x0004A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943225, XrefRangeEnd = 943227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(SteamId steamid, string name, int defaultValue = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_GetInt_Public_Static_Int32_SteamId_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0004C38C File Offset: 0x0004A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943227, XrefRangeEnd = 943229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(SteamId steamid, string name, float defaultValue = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_GetFloat_Public_Static_Single_SteamId_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943229, XrefRangeEnd = 943232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetAchievement(SteamId steamid, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0004C43C File Offset: 0x0004A63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943232, XrefRangeEnd = 943235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearAchievement(SteamId steamid, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0004C48C File Offset: 0x0004A68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943235, XrefRangeEnd = 943237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievement(SteamId steamid, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_SteamId_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943237, XrefRangeEnd = 943250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Result> StoreUserStats(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr_StoreUserStats_Public_Static_Task_1_Result_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Result>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0004C51C File Offset: 0x0004A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943250, XrefRangeEnd = 943253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamServerStats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002C57 File Offset: 0x00000E57
		public SteamServerStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamGameServerStats_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStatsAsync_Public_Static_Task_1_Result_SteamId_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Boolean_SteamId_String_Int32_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Boolean_SteamId_String_Single_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_SteamId_String_Int32_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_SteamId_String_Single_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_SteamId_String_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_SteamId_String_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_SteamId_String_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_StoreUserStats_Public_Static_Task_1_Result_SteamId_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000254 RID: 596
		[ObfuscatedName("Steamworks.SteamServerStats+<RequestUserStatsAsync>d__3")]
		public sealed class _RequestUserStatsAsync_d__3 : ValueType
		{
			// Token: 0x06001E09 RID: 7689 RVA: 0x00088F1C File Offset: 0x0008711C
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestUserStatsAsync_d__3()
			{
				Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, "<RequestUserStatsAsync>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr);
				SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, "<>1__state");
				SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, "<>t__builder");
				SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, "steamid");
				SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, "<>u__1");
				SteamServerStats._RequestUserStatsAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, 100665946);
				SteamServerStats._RequestUserStatsAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr, 100665947);
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x00088FC0 File Offset: 0x000871C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943132, XrefRangeEnd = 943156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats._RequestUserStatsAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x00088FF8 File Offset: 0x000871F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943156, XrefRangeEnd = 943162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats._RequestUserStatsAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E0C RID: 7692 RVA: 0x0000AB3A File Offset: 0x00008D3A
			public _RequestUserStatsAsync_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x0000AB43 File Offset: 0x00008D43
			public _RequestUserStatsAsync_d__3()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServerStats._RequestUserStatsAsync_d__3>.NativeClassPtr))
			{
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00089040 File Offset: 0x00087240
			// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0000AB55 File Offset: 0x00008D55
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00089068 File Offset: 0x00087268
			// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0000AB70 File Offset: 0x00008D70
			public AsyncTaskMethodBuilder<Result> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Result>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00089098 File Offset: 0x00087298
			// (set) Token: 0x06001E13 RID: 7699 RVA: 0x0000AB9E File Offset: 0x00008D9E
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000890C0 File Offset: 0x000872C0
			// (set) Token: 0x06001E15 RID: 7701 RVA: 0x0000ABB9 File Offset: 0x00008DB9
			public CallResult<GSStatsReceived_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___u__1);
					return new CallResult<GSStatsReceived_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GSStatsReceived_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._RequestUserStatsAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GSStatsReceived_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002184 RID: 8580
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002185 RID: 8581
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002186 RID: 8582
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x04002187 RID: 8583
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002188 RID: 8584
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002189 RID: 8585
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000255 RID: 597
		[ObfuscatedName("Steamworks.SteamServerStats+<StoreUserStats>d__11")]
		public sealed class _StoreUserStats_d__11 : ValueType
		{
			// Token: 0x06001E16 RID: 7702 RVA: 0x000890F0 File Offset: 0x000872F0
			// Note: this type is marked as 'beforefieldinit'.
			static _StoreUserStats_d__11()
			{
				Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamServerStats>.NativeClassPtr, "<StoreUserStats>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr);
				SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, "<>1__state");
				SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, "<>t__builder");
				SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr_steamid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, "steamid");
				SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, "<>u__1");
				SteamServerStats._StoreUserStats_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, 100665948);
				SteamServerStats._StoreUserStats_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr, 100665949);
			}

			// Token: 0x06001E17 RID: 7703 RVA: 0x00089194 File Offset: 0x00087394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943162, XrefRangeEnd = 943186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats._StoreUserStats_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E18 RID: 7704 RVA: 0x000891CC File Offset: 0x000873CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943186, XrefRangeEnd = 943192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerStats._StoreUserStats_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E19 RID: 7705 RVA: 0x0000ABE7 File Offset: 0x00008DE7
			public _StoreUserStats_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E1A RID: 7706 RVA: 0x0000ABF0 File Offset: 0x00008DF0
			public _StoreUserStats_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamServerStats._StoreUserStats_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00089214 File Offset: 0x00087414
			// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0000AC02 File Offset: 0x00008E02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0008923C File Offset: 0x0008743C
			// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0000AC1D File Offset: 0x00008E1D
			public AsyncTaskMethodBuilder<Result> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Result>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0008926C File Offset: 0x0008746C
			// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0000AC4B File Offset: 0x00008E4B
			public unsafe SteamId steamid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr_steamid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr_steamid)) = value;
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06001E21 RID: 7713 RVA: 0x00089294 File Offset: 0x00087494
			// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0000AC66 File Offset: 0x00008E66
			public CallResult<GSStatsStored_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___u__1);
					return new CallResult<GSStatsStored_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GSStatsStored_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamServerStats._StoreUserStats_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GSStatsStored_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400218A RID: 8586
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400218B RID: 8587
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400218C RID: 8588
			private static readonly IntPtr NativeFieldInfoPtr_steamid;

			// Token: 0x0400218D RID: 8589
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400218E RID: 8590
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400218F RID: 8591
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
