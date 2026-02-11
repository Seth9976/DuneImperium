using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace dwd.core.input.compositeModule
{
	// Token: 0x020000A5 RID: 165
	public class InputModuleTypeNotifier : MonoBehaviour
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x00029E78 File Offset: 0x00028078
		// Note: this type is marked as 'beforefieldinit'.
		static InputModuleTypeNotifier()
		{
			Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.input.compositeModule", "InputModuleTypeNotifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr);
			InputModuleTypeNotifier.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, "updateManager");
			InputModuleTypeNotifier.NativeFieldInfoPtr_cachedInputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, "cachedInputModuleType");
			InputModuleTypeNotifier.NativeMethodInfoPtr_get_CurrentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664539);
			InputModuleTypeNotifier.NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664540);
			InputModuleTypeNotifier.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664541);
			InputModuleTypeNotifier.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664542);
			InputModuleTypeNotifier.NativeMethodInfoPtr_notificationConditionMet_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664543);
			InputModuleTypeNotifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr, 100664544);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00029F48 File Offset: 0x00028148
		public unsafe string CurrentType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr_get_CurrentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00029F80 File Offset: 0x00028180
		public unsafe bool IsGamepad
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991125, XrefRangeEnd = 991128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00029FBC File Offset: 0x000281BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991128, XrefRangeEnd = 991132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00029FF0 File Offset: 0x000281F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991132, XrefRangeEnd = 991140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002A024 File Offset: 0x00028224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991140, XrefRangeEnd = 991146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool notificationConditionMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr_notificationConditionMet_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002A060 File Offset: 0x00028260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991146, XrefRangeEnd = 991150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputModuleTypeNotifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputModuleTypeNotifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleTypeNotifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000595A File Offset: 0x00003B5A
		public InputModuleTypeNotifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0002A09C File Offset: 0x0002829C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00005963 File Offset: 0x00003B63
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleTypeNotifier.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleTypeNotifier.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0002A0CC File Offset: 0x000282CC
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00005982 File Offset: 0x00003B82
		public unsafe string cachedInputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleTypeNotifier.NativeFieldInfoPtr_cachedInputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleTypeNotifier.NativeFieldInfoPtr_cachedInputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_cachedInputModuleType;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentType_Public_get_String_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGamepad_Public_get_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_notificationConditionMet_Protected_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
