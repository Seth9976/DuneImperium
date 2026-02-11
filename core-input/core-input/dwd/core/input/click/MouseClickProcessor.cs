using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000AC RID: 172
	public class MouseClickProcessor : global::Il2CppSystem.Object
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x000200F4 File Offset: 0x0001E2F4
		// Note: this type is marked as 'beforefieldinit'.
		static MouseClickProcessor()
		{
			Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "MouseClickProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr);
			MouseClickProcessor.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "transform");
			MouseClickProcessor.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "config");
			MouseClickProcessor.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "buttons");
			MouseClickProcessor.NativeFieldInfoPtr_pendingButtonsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "pendingButtonsToAdd");
			MouseClickProcessor.NativeFieldInfoPtr_lastDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "lastDownTime");
			MouseClickProcessor.NativeFieldInfoPtr_lastUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "lastUpTime");
			MouseClickProcessor.NativeFieldInfoPtr_readyForCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "readyForCleanup");
			MouseClickProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, 100664253);
			MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, 100664254);
			MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, 100664255);
			MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, 100664256);
			MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, 100664257);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00020214 File Offset: 0x0001E414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126671, XrefRangeEnd = 1126692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseClickProcessor(Transform transform, IClickConfig config)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00020274 File Offset: 0x0001E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126692, XrefRangeEnd = 1126742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Process(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000202B8 File Offset: 0x0001E4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126742, XrefRangeEnd = 1126801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Update(float unscaledTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000202F8 File Offset: 0x0001E4F8
		public unsafe virtual Transform dwd.core.input.transforms.IPressProcessor.Transform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00020338 File Offset: 0x0001E538
		public unsafe virtual bool dwd.core.input.transforms.IPressProcessor.ReadyForCleanUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0000606A File Offset: 0x0000426A
		public MouseClickProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00020374 File Offset: 0x0001E574
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00006073 File Offset: 0x00004273
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x000203A4 File Offset: 0x0001E5A4
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00006092 File Offset: 0x00004292
		public unsafe IClickConfig config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClickConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x000203D4 File Offset: 0x0001E5D4
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x000060B1 File Offset: 0x000042B1
		public unsafe Dictionary<MouseButton, MouseClickProcessor.MouseButtonInfo> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MouseButton, MouseClickProcessor.MouseButtonInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00020404 File Offset: 0x0001E604
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x000060D0 File Offset: 0x000042D0
		public unsafe List<ValueTuple<MouseButton, MouseClickProcessor.MouseButtonInfo>> pendingButtonsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_pendingButtonsToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<MouseButton, MouseClickProcessor.MouseButtonInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_pendingButtonsToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00020434 File Offset: 0x0001E634
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x000060EF File Offset: 0x000042EF
		public unsafe float lastDownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_lastDownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_lastDownTime)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0002045C File Offset: 0x0001E65C
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0000610A File Offset: 0x0000430A
		public unsafe float lastUpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_lastUpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_lastUpTime)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00020484 File Offset: 0x0001E684
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00006125 File Offset: 0x00004325
		public unsafe bool readyForCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_readyForCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.NativeFieldInfoPtr_readyForCleanup)) = value;
			}
		}

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_config;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_pendingButtonsToAdd;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_lastDownTime;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_lastUpTime;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_readyForCleanup;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x020000DC RID: 220
		public class MouseButtonInfo : global::Il2CppSystem.Object
		{
			// Token: 0x060009B2 RID: 2482 RVA: 0x00026168 File Offset: 0x00024368
			// Note: this type is marked as 'beforefieldinit'.
			static MouseButtonInfo()
			{
				Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseClickProcessor>.NativeClassPtr, "MouseButtonInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr);
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "Button");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "Press");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Consecutive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "Consecutive");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "IsDown");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "IsLongPress");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPressSloppy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "IsLongPressSloppy");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastUpTimeUnscaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "LastUpTimeUnscaled");
				MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, "LastClickPosition");
				MouseClickProcessor.MouseButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr, 100664258);
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x00026248 File Offset: 0x00024448
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseButtonInfo(MouseButton button)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseClickProcessor.MouseButtonInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseClickProcessor.MouseButtonInfo.NativeMethodInfoPtr__ctor_Public_Void_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x0000709F File Offset: 0x0000529F
			public MouseButtonInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00026290 File Offset: 0x00024490
			// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000070A8 File Offset: 0x000052A8
			public unsafe MouseButton Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Button);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Button)) = value;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000262B8 File Offset: 0x000244B8
			// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000070C3 File Offset: 0x000052C3
			public unsafe MousePress Press
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Press);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Press), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000262E8 File Offset: 0x000244E8
			// (set) Token: 0x060009BA RID: 2490 RVA: 0x000070E2 File Offset: 0x000052E2
			public unsafe int Consecutive
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Consecutive);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_Consecutive)) = value;
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x060009BB RID: 2491 RVA: 0x00026310 File Offset: 0x00024510
			// (set) Token: 0x060009BC RID: 2492 RVA: 0x000070FD File Offset: 0x000052FD
			public unsafe bool IsDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsDown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsDown)) = value;
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x060009BD RID: 2493 RVA: 0x00026338 File Offset: 0x00024538
			// (set) Token: 0x060009BE RID: 2494 RVA: 0x00007118 File Offset: 0x00005318
			public unsafe bool IsLongPress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPress)) = value;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x060009BF RID: 2495 RVA: 0x00026360 File Offset: 0x00024560
			// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00007133 File Offset: 0x00005333
			public unsafe bool IsLongPressSloppy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPressSloppy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_IsLongPressSloppy)) = value;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00026388 File Offset: 0x00024588
			// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0000714E File Offset: 0x0000534E
			public unsafe float LastUpTimeUnscaled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastUpTimeUnscaled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastUpTimeUnscaled)) = value;
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000263B0 File Offset: 0x000245B0
			// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00007169 File Offset: 0x00005369
			public unsafe Vector2 LastClickPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastClickPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseClickProcessor.MouseButtonInfo.NativeFieldInfoPtr_LastClickPosition)) = value;
				}
			}

			// Token: 0x040005FD RID: 1533
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x040005FE RID: 1534
			private static readonly IntPtr NativeFieldInfoPtr_Press;

			// Token: 0x040005FF RID: 1535
			private static readonly IntPtr NativeFieldInfoPtr_Consecutive;

			// Token: 0x04000600 RID: 1536
			private static readonly IntPtr NativeFieldInfoPtr_IsDown;

			// Token: 0x04000601 RID: 1537
			private static readonly IntPtr NativeFieldInfoPtr_IsLongPress;

			// Token: 0x04000602 RID: 1538
			private static readonly IntPtr NativeFieldInfoPtr_IsLongPressSloppy;

			// Token: 0x04000603 RID: 1539
			private static readonly IntPtr NativeFieldInfoPtr_LastUpTimeUnscaled;

			// Token: 0x04000604 RID: 1540
			private static readonly IntPtr NativeFieldInfoPtr_LastClickPosition;

			// Token: 0x04000605 RID: 1541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MouseButton_0;
		}
	}
}
