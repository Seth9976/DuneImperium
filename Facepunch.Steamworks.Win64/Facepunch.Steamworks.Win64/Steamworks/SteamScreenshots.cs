using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000AC RID: 172
	public class SteamScreenshots : SteamClientClass<SteamScreenshots>
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x0004A67C File Offset: 0x0004887C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamScreenshots()
		{
			Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamScreenshots");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr);
			SteamScreenshots.NativeFieldInfoPtr_OnScreenshotRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, "OnScreenshotRequested");
			SteamScreenshots.NativeFieldInfoPtr_OnScreenshotReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, "OnScreenshotReady");
			SteamScreenshots.NativeFieldInfoPtr_OnScreenshotFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, "OnScreenshotFailed");
			SteamScreenshots.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamScreenshots_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665850);
			SteamScreenshots.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665851);
			SteamScreenshots.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665852);
			SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotRequested_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665853);
			SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotRequested_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665854);
			SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotReady_Public_Static_add_Void_Action_1_Screenshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665855);
			SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotReady_Public_Static_rem_Void_Action_1_Screenshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665856);
			SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotFailed_Public_Static_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665857);
			SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotFailed_Public_Static_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665858);
			SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_Nullable_1_Screenshot_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665859);
			SteamScreenshots.NativeMethodInfoPtr_AddScreenshot_Public_Static_Nullable_1_Screenshot_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665860);
			SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665861);
			SteamScreenshots.NativeMethodInfoPtr_get_Hooked_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665862);
			SteamScreenshots.NativeMethodInfoPtr_set_Hooked_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665863);
			SteamScreenshots.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, 100665864);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0004A814 File Offset: 0x00048A14
		public unsafe static ISteamScreenshots Internal
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 942162, RefRangeEnd = 942171, XrefRangeStart = 942159, XrefRangeEnd = 942162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamScreenshots_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamScreenshots>(intPtr3) : null;
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0004A848 File Offset: 0x00048A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942171, XrefRangeEnd = 942176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamScreenshots.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0004A894 File Offset: 0x00048A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 942216, RefRangeEnd = 942217, XrefRangeStart = 942176, XrefRangeEnd = 942216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0004A8BC File Offset: 0x00048ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942217, XrefRangeEnd = 942224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnScreenshotRequested(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotRequested_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0004A8F4 File Offset: 0x00048AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942224, XrefRangeEnd = 942231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnScreenshotRequested(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotRequested_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0004A92C File Offset: 0x00048B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942231, XrefRangeEnd = 942240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnScreenshotReady(Action<Screenshot> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotReady_Public_Static_add_Void_Action_1_Screenshot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0004A964 File Offset: 0x00048B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942240, XrefRangeEnd = 942249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnScreenshotReady(Action<Screenshot> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotReady_Public_Static_rem_Void_Action_1_Screenshot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0004A99C File Offset: 0x00048B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942249, XrefRangeEnd = 942258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnScreenshotFailed(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_add_OnScreenshotFailed_Public_Static_add_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0004A9D4 File Offset: 0x00048BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942258, XrefRangeEnd = 942267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnScreenshotFailed(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_remove_OnScreenshotFailed_Public_Static_rem_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0004AA0C File Offset: 0x00048C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942267, XrefRangeEnd = 942276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<Screenshot> WriteScreenshot(Il2CppStructArray<byte> data, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Public_Static_Nullable_1_Screenshot_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Screenshot>(intPtr);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0004AA64 File Offset: 0x00048C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942276, XrefRangeEnd = 942281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<Screenshot> AddScreenshot(string filename, string thumbnail, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(thumbnail);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_AddScreenshot_Public_Static_Nullable_1_Screenshot_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Screenshot>(intPtr);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0004AAD0 File Offset: 0x00048CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942281, XrefRangeEnd = 942284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerScreenshot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0004AAF8 File Offset: 0x00048CF8
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0004AB28 File Offset: 0x00048D28
		public unsafe static bool Hooked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942284, XrefRangeEnd = 942287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_get_Hooked_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942287, XrefRangeEnd = 942290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr_set_Hooked_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0004AB5C File Offset: 0x00048D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942290, XrefRangeEnd = 942293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamScreenshots()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00002AED File Offset: 0x00000CED
		public SteamScreenshots(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0004AB98 File Offset: 0x00048D98
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public unsafe static Action OnScreenshotRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0004ABC0 File Offset: 0x00048DC0
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00002B08 File Offset: 0x00000D08
		public unsafe static Action<Screenshot> OnScreenshotReady
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotReady, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Screenshot>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotReady, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0004ABE8 File Offset: 0x00048DE8
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00002B1A File Offset: 0x00000D1A
		public unsafe static Action<Result> OnScreenshotFailed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotFailed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.NativeFieldInfoPtr_OnScreenshotFailed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_OnScreenshotRequested;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_OnScreenshotReady;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_OnScreenshotFailed;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamScreenshots_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenshotRequested_Public_Static_add_Void_Action_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenshotRequested_Public_Static_rem_Void_Action_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenshotReady_Public_Static_add_Void_Action_1_Screenshot_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenshotReady_Public_Static_rem_Void_Action_1_Screenshot_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenshotFailed_Public_Static_add_Void_Action_1_Result_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenshotFailed_Public_Static_rem_Void_Action_1_Result_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenshot_Public_Static_Nullable_1_Screenshot_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_AddScreenshot_Public_Static_Nullable_1_Screenshot_String_String_Int32_Int32_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_TriggerScreenshot_Public_Static_Void_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_get_Hooked_Public_Static_get_Boolean_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_set_Hooked_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000251 RID: 593
		[ObfuscatedName("Steamworks.SteamScreenshots+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DE9 RID: 7657 RVA: 0x00088960 File Offset: 0x00086B60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamScreenshots>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr);
				SteamScreenshots.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, "<>9");
				SteamScreenshots.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, "<>9__3_0");
				SteamScreenshots.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, "<>9__3_1");
				SteamScreenshots.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, 100665866);
				SteamScreenshots.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_ScreenshotRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, 100665867);
				SteamScreenshots.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ScreenshotReady_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr, 100665868);
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x00088A04 File Offset: 0x00086C04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamScreenshots.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x00088A40 File Offset: 0x00086C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942154, XrefRangeEnd = 942156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(ScreenshotRequested_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_ScreenshotRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DEC RID: 7660 RVA: 0x00088A80 File Offset: 0x00086C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942156, XrefRangeEnd = 942159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(ScreenshotReady_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamScreenshots.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ScreenshotReady_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DED RID: 7661 RVA: 0x0000AA86 File Offset: 0x00008C86
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00088AC0 File Offset: 0x00086CC0
			// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000AA8F File Offset: 0x00008C8F
			public unsafe static SteamScreenshots.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamScreenshots.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00088AE8 File Offset: 0x00086CE8
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000AAA1 File Offset: 0x00008CA1
			public unsafe static Action<ScreenshotRequested_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScreenshotRequested_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00088B10 File Offset: 0x00086D10
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000AAB3 File Offset: 0x00008CB3
			public unsafe static Action<ScreenshotReady_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamScreenshots.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScreenshotReady_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamScreenshots.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002171 RID: 8561
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002172 RID: 8562
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002173 RID: 8563
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04002174 RID: 8564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002175 RID: 8565
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_ScreenshotRequested_t_0;

			// Token: 0x04002176 RID: 8566
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_ScreenshotReady_t_0;
		}
	}
}
