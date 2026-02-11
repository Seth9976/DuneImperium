using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000AD RID: 173
	public class SingleTouchClickProcessor : global::Il2CppSystem.Object
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000204AC File Offset: 0x0001E6AC
		// Note: this type is marked as 'beforefieldinit'.
		static SingleTouchClickProcessor()
		{
			Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "SingleTouchClickProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr);
			SingleTouchClickProcessor.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "transform");
			SingleTouchClickProcessor.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "config");
			SingleTouchClickProcessor.NativeFieldInfoPtr_activePress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "activePress");
			SingleTouchClickProcessor.NativeFieldInfoPtr_consecutive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "consecutive");
			SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "isLongPress");
			SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPressSloppy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "isLongPressSloppy");
			SingleTouchClickProcessor.NativeFieldInfoPtr_lastUpTimeUnscaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "lastUpTimeUnscaled");
			SingleTouchClickProcessor.NativeFieldInfoPtr_lastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "lastClickPosition");
			SingleTouchClickProcessor.NativeFieldInfoPtr_readyForCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, "readyForCleanup");
			SingleTouchClickProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, 100664259);
			SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, 100664260);
			SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, 100664261);
			SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, 100664262);
			SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr, 100664263);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000205F4 File Offset: 0x0001E7F4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleTouchClickProcessor(Transform transform, IClickConfig config)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleTouchClickProcessor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTouchClickProcessor.NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00020654 File Offset: 0x0001E854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126801, XrefRangeEnd = 1126824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Process(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00020698 File Offset: 0x0001E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126824, XrefRangeEnd = 1126845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_input_transforms_IPressProcessor_Update(float unscaledTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000206D8 File Offset: 0x0001E8D8
		public unsafe virtual Transform dwd.core.input.transforms.IPressProcessor.Transform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00020718 File Offset: 0x0001E918
		public unsafe virtual bool dwd.core.input.transforms.IPressProcessor.ReadyForCleanUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleTouchClickProcessor.NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00006140 File Offset: 0x00004340
		public SingleTouchClickProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00020754 File Offset: 0x0001E954
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00006149 File Offset: 0x00004349
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00020784 File Offset: 0x0001E984
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00006168 File Offset: 0x00004368
		public unsafe IClickConfig config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClickConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000207B4 File Offset: 0x0001E9B4
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00006187 File Offset: 0x00004387
		public unsafe TouchPress activePress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_activePress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_activePress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000207E4 File Offset: 0x0001E9E4
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000061A6 File Offset: 0x000043A6
		public unsafe int consecutive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_consecutive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_consecutive)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002080C File Offset: 0x0001EA0C
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000061C1 File Offset: 0x000043C1
		public unsafe bool isLongPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPress)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00020834 File Offset: 0x0001EA34
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x000061DC File Offset: 0x000043DC
		public unsafe bool isLongPressSloppy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPressSloppy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_isLongPressSloppy)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0002085C File Offset: 0x0001EA5C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x000061F7 File Offset: 0x000043F7
		public unsafe float lastUpTimeUnscaled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_lastUpTimeUnscaled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_lastUpTimeUnscaled)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00020884 File Offset: 0x0001EA84
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00006212 File Offset: 0x00004412
		public unsafe Vector2 lastClickPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_lastClickPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_lastClickPosition)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000208AC File Offset: 0x0001EAAC
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0000622D File Offset: 0x0000442D
		public unsafe bool readyForCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_readyForCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleTouchClickProcessor.NativeFieldInfoPtr_readyForCleanup)) = value;
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_config;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_activePress;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_consecutive;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_isLongPress;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_isLongPressSloppy;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_lastUpTimeUnscaled;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_lastClickPosition;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_readyForCleanup;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_IClickConfig_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Process_Private_Virtual_Final_New_Void_PressEvent_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_Update_Private_Virtual_Final_New_Void_Single_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_Transform_Private_Virtual_Final_New_get_Transform_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_input_transforms_IPressProcessor_get_ReadyForCleanUp_Private_Virtual_Final_New_get_Boolean_0;
	}
}
