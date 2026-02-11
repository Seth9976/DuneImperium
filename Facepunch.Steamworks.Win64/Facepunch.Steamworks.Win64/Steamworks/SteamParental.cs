using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A8 RID: 168
	public class SteamParental : SteamSharedClass<SteamParental>
	{
		// Token: 0x06000A14 RID: 2580 RVA: 0x0004943C File Offset: 0x0004763C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParental()
		{
			Il2CppClassPointerStore<SteamParental>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamParental");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParental>.NativeClassPtr);
			SteamParental.NativeFieldInfoPtr_OnSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, "OnSettingsChanged");
			SteamParental.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParentalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665770);
			SteamParental.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665771);
			SteamParental.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665772);
			SteamParental.NativeMethodInfoPtr_add_OnSettingsChanged_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665773);
			SteamParental.NativeMethodInfoPtr_remove_OnSettingsChanged_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665774);
			SteamParental.NativeMethodInfoPtr_get_IsParentalLockEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665775);
			SteamParental.NativeMethodInfoPtr_get_IsParentalLockLocked_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665776);
			SteamParental.NativeMethodInfoPtr_IsAppBlocked_Public_Static_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665777);
			SteamParental.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665778);
			SteamParental.NativeMethodInfoPtr_IsFeatureBlocked_Public_Static_Boolean_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665779);
			SteamParental.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_ParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665780);
			SteamParental.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, 100665781);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00049570 File Offset: 0x00047770
		public unsafe static ISteamParentalSettings Internal
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 941711, RefRangeEnd = 941717, XrefRangeStart = 941707, XrefRangeEnd = 941711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParentalSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamParentalSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000495A4 File Offset: 0x000477A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941717, XrefRangeEnd = 941742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamParental.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000495F0 File Offset: 0x000477F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941742, XrefRangeEnd = 941763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents(bool server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00049624 File Offset: 0x00047824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941763, XrefRangeEnd = 941770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSettingsChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_add_OnSettingsChanged_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0004965C File Offset: 0x0004785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941770, XrefRangeEnd = 941777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSettingsChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_remove_OnSettingsChanged_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00049694 File Offset: 0x00047894
		public unsafe static bool IsParentalLockEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941777, XrefRangeEnd = 941780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_get_IsParentalLockEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x000496C4 File Offset: 0x000478C4
		public unsafe static bool IsParentalLockLocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941780, XrefRangeEnd = 941783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_get_IsParentalLockLocked_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000496F4 File Offset: 0x000478F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941783, XrefRangeEnd = 941787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAppBlocked(AppId app)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref app;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_IsAppBlocked_Public_Static_Boolean_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00049734 File Offset: 0x00047934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941787, XrefRangeEnd = 941791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppInBlockList(AppId app)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref app;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00049774 File Offset: 0x00047974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941791, XrefRangeEnd = 941794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFeatureBlocked(ParentalFeature feature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref feature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_IsFeatureBlocked_Public_Static_Boolean_ParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x000497B4 File Offset: 0x000479B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941794, XrefRangeEnd = 941797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsFeatureInBlockList(ParentalFeature feature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref feature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_ParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000497F4 File Offset: 0x000479F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941797, XrefRangeEnd = 941800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamParental()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParental>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00002A6F File Offset: 0x00000C6F
		public SteamParental(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00049830 File Offset: 0x00047A30
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00002A78 File Offset: 0x00000C78
		public unsafe static Action OnSettingsChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamParental.NativeFieldInfoPtr_OnSettingsChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParental.NativeFieldInfoPtr_OnSettingsChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_OnSettingsChanged;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamParentalSettings_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_Boolean_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSettingsChanged_Public_Static_add_Void_Action_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSettingsChanged_Public_Static_rem_Void_Action_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_get_IsParentalLockEnabled_Public_Static_get_Boolean_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_get_IsParentalLockLocked_Public_Static_get_Boolean_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_IsAppBlocked_Public_Static_Boolean_AppId_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_IsFeatureBlocked_Public_Static_Boolean_ParentalFeature_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_ParentalFeature_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024C RID: 588
		[ObfuscatedName("Steamworks.SteamParental+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DA5 RID: 7589 RVA: 0x00087CE8 File Offset: 0x00085EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamParental>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr);
				SteamParental.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr, "<>9");
				SteamParental.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr, "<>9__3_0");
				SteamParental.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr, 100665783);
				SteamParental.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamParentalSettingsChanged_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr, 100665784);
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x00087D64 File Offset: 0x00085F64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParental.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DA7 RID: 7591 RVA: 0x00087DA0 File Offset: 0x00085FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941705, XrefRangeEnd = 941707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(SteamParentalSettingsChanged_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParental.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamParentalSettingsChanged_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DA8 RID: 7592 RVA: 0x0000A8D2 File Offset: 0x00008AD2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00087DE0 File Offset: 0x00085FE0
			// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0000A8DB File Offset: 0x00008ADB
			public unsafe static SteamParental.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamParental.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamParental.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamParental.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00087E08 File Offset: 0x00086008
			// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000A8ED File Offset: 0x00008AED
			public unsafe static Action<SteamParentalSettingsChanged_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamParental.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamParentalSettingsChanged_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamParental.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002148 RID: 8520
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002149 RID: 8521
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400214A RID: 8522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400214B RID: 8523
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_SteamParentalSettingsChanged_t_0;
		}
	}
}
