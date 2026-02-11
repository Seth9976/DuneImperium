using System;
using dwd.core.commands;
using dwd.iap.store;
using iap.claims;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading.Tasks;
using Steamworks;

namespace dwd.iap.steam
{
	// Token: 0x02000007 RID: 7
	public class PurchaseSteamProductCommand : Command
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002ED8 File Offset: 0x000010D8
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseSteamProductCommand()
		{
			Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Steam.dll", "dwd.iap.steam", "PurchaseSteamProductCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr);
			PurchaseSteamProductCommand.NativeFieldInfoPtr_NO_STEAM_OVERLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "NO_STEAM_OVERLAY");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "waiting");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_interrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "interrupted");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_autoCancelTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "autoCancelTime");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "model");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "product");
			PurchaseSteamProductCommand.NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "language");
			PurchaseSteamProductCommand.NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_IAPProduct_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663340);
			PurchaseSteamProductCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663341);
			PurchaseSteamProductCommand.NativeMethodInfoPtr_OverlayClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663342);
			PurchaseSteamProductCommand.NativeMethodInfoPtr_claimResponseHandler_Private_Void_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663343);
			PurchaseSteamProductCommand.NativeMethodInfoPtr_claimFailureHandler_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663344);
			PurchaseSteamProductCommand.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, 100663345);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000300C File Offset: 0x0000120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257740, XrefRangeEnd = 1257744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseSteamProductCommand(SteamIAPStoreModel model, IAPProduct product, string language)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(language);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand.NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_IAPProduct_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000307C File Offset: 0x0000127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257744, XrefRangeEnd = 1257749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PurchaseSteamProductCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000030C8 File Offset: 0x000012C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257749, XrefRangeEnd = 1257750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverlayClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand.NativeMethodInfoPtr_OverlayClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000030FC File Offset: 0x000012FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257750, XrefRangeEnd = 1257768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void claimResponseHandler(ClaimResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand.NativeMethodInfoPtr_claimResponseHandler_Private_Void_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003140 File Offset: 0x00001340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257768, XrefRangeEnd = 1257775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void claimFailureHandler(string failure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(failure);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand.NativeMethodInfoPtr_claimFailureHandler_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003184 File Offset: 0x00001384
		[CallerCount(0)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020DA File Offset: 0x000002DA
		public PurchaseSteamProductCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000031B8 File Offset: 0x000013B8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000020E3 File Offset: 0x000002E3
		public unsafe static string NO_STEAM_OVERLAY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PurchaseSteamProductCommand.NativeFieldInfoPtr_NO_STEAM_OVERLAY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PurchaseSteamProductCommand.NativeFieldInfoPtr_NO_STEAM_OVERLAY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000031D8 File Offset: 0x000013D8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000020F5 File Offset: 0x000002F5
		public unsafe bool waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_waiting)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003200 File Offset: 0x00001400
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002110 File Offset: 0x00000310
		public unsafe bool interrupted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_interrupted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_interrupted)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000212B File Offset: 0x0000032B
		public unsafe float autoCancelTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_autoCancelTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_autoCancelTime)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003250 File Offset: 0x00001450
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe SteamIAPStoreModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamIAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003280 File Offset: 0x00001480
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002165 File Offset: 0x00000365
		public unsafe IAPProduct product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000032B0 File Offset: 0x000014B0
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002184 File Offset: 0x00000384
		public unsafe string language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand.NativeFieldInfoPtr_language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_NO_STEAM_OVERLAY;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_waiting;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_interrupted;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_autoCancelTime;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_product;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_language;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamIAPStoreModel_IAPProduct_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_OverlayClosed_Public_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_claimResponseHandler_Private_Void_ClaimResponse_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_claimFailureHandler_Public_Void_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x02000012 RID: 18
		[ObfuscatedName("dwd.iap.steam.PurchaseSteamProductCommand+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x060000BF RID: 191 RVA: 0x00004C20 File Offset: 0x00002E20
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchaseSteamProductCommand>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr);
				PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, "<>1__state");
				PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, "<>2__current");
				PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, "<>4__this");
				PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__id_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, "<id>5__2");
				PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__authTicket_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, "<authTicket>5__3");
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663346);
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663347);
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663348);
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663349);
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663350);
				PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr, 100663351);
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00004D28 File Offset: 0x00002F28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseSteamProductCommand._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00004D70 File Offset: 0x00002F70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00004DA4 File Offset: 0x00002FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257667, XrefRangeEnd = 1257735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004DE0 File Offset: 0x00002FE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00004E20 File Offset: 0x00003020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257735, XrefRangeEnd = 1257740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x00004E54 File Offset: 0x00003054
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseSteamProductCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00002653 File Offset: 0x00000853
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004E94 File Offset: 0x00003094
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000265C File Offset: 0x0000085C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004EBC File Offset: 0x000030BC
			// (set) Token: 0x060000CA RID: 202 RVA: 0x00002677 File Offset: 0x00000877
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000CB RID: 203 RVA: 0x00004EEC File Offset: 0x000030EC
			// (set) Token: 0x060000CC RID: 204 RVA: 0x00002696 File Offset: 0x00000896
			public unsafe PurchaseSteamProductCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseSteamProductCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000CD RID: 205 RVA: 0x00004F1C File Offset: 0x0000311C
			// (set) Token: 0x060000CE RID: 206 RVA: 0x000026B5 File Offset: 0x000008B5
			public unsafe int _id_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__id_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__id_5__2)) = value;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000CF RID: 207 RVA: 0x00004F44 File Offset: 0x00003144
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x000026D0 File Offset: 0x000008D0
			public unsafe Task<AuthTicket> _authTicket_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__authTicket_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<AuthTicket>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseSteamProductCommand._execute_d__8.NativeFieldInfoPtr__authTicket_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeFieldInfoPtr__id_5__2;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeFieldInfoPtr__authTicket_5__3;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
