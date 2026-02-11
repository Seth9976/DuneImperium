using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000B0 RID: 176
	public class ChatMessageThrottler : MonoBehaviour
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		// Note: this type is marked as 'beforefieldinit'.
		static ChatMessageThrottler()
		{
			Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatMessageThrottler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr);
			ChatMessageThrottler.NativeFieldInfoPtr_messageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "messageDelay");
			ChatMessageThrottler.NativeFieldInfoPtr_spamWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamWindow");
			ChatMessageThrottler.NativeFieldInfoPtr_spamCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamCount");
			ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamBlockDuration");
			ChatMessageThrottler.NativeFieldInfoPtr_emoteTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "emoteTimes");
			ChatMessageThrottler.NativeFieldInfoPtr_messageDelaySpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "messageDelaySpan");
			ChatMessageThrottler.NativeFieldInfoPtr_spamWindowSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamWindowSpan");
			ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDurationSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamBlockDurationSpan");
			ChatMessageThrottler.NativeFieldInfoPtr_spamBlockEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, "spamBlockEndTime");
			ChatMessageThrottler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, 100664690);
			ChatMessageThrottler.NativeMethodInfoPtr_IsMessageDelayed_Public_Virtual_Final_New_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, 100664691);
			ChatMessageThrottler.NativeMethodInfoPtr_IsMessageBlocked_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, 100664692);
			ChatMessageThrottler.NativeMethodInfoPtr_RecordSentMessage_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, 100664693);
			ChatMessageThrottler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr, 100664694);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002D318 File Offset: 0x0002B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991926, XrefRangeEnd = 991929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageThrottler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0002D34C File Offset: 0x0002B54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991929, XrefRangeEnd = 991963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsMessageDelayed(out float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageThrottler.NativeMethodInfoPtr_IsMessageDelayed_Public_Virtual_Final_New_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002D398 File Offset: 0x0002B598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991963, XrefRangeEnd = 991996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsMessageBlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageThrottler.NativeMethodInfoPtr_IsMessageBlocked_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002D3D4 File Offset: 0x0002B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991996, XrefRangeEnd = 992004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordSentMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageThrottler.NativeMethodInfoPtr_RecordSentMessage_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002D408 File Offset: 0x0002B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992004, XrefRangeEnd = 992012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatMessageThrottler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageThrottler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageThrottler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00006103 File Offset: 0x00004303
		public ChatMessageThrottler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002D444 File Offset: 0x0002B644
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0000610C File Offset: 0x0000430C
		public unsafe int messageDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_messageDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_messageDelay)) = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0002D46C File Offset: 0x0002B66C
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00006127 File Offset: 0x00004327
		public unsafe int spamWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamWindow)) = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0002D494 File Offset: 0x0002B694
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00006142 File Offset: 0x00004342
		public unsafe int spamCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamCount)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0000615D File Offset: 0x0000435D
		public unsafe int spamBlockDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDuration)) = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00006178 File Offset: 0x00004378
		public unsafe Queue<DateTime> emoteTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_emoteTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DateTime>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_emoteTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002D514 File Offset: 0x0002B714
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00006197 File Offset: 0x00004397
		public unsafe TimeSpan messageDelaySpan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_messageDelaySpan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_messageDelaySpan)) = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002D53C File Offset: 0x0002B73C
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000061B2 File Offset: 0x000043B2
		public unsafe TimeSpan spamWindowSpan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamWindowSpan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamWindowSpan)) = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0002D564 File Offset: 0x0002B764
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000061CD File Offset: 0x000043CD
		public unsafe TimeSpan spamBlockDurationSpan
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDurationSpan);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockDurationSpan)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0002D58C File Offset: 0x0002B78C
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000061E8 File Offset: 0x000043E8
		public unsafe DateTime spamBlockEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageThrottler.NativeFieldInfoPtr_spamBlockEndTime)) = value;
			}
		}

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_messageDelay;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_spamWindow;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_spamCount;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_spamBlockDuration;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_emoteTimes;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_messageDelaySpan;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_spamWindowSpan;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_spamBlockDurationSpan;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_spamBlockEndTime;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_IsMessageDelayed_Public_Virtual_Final_New_Boolean_byref_Single_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_IsMessageBlocked_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_RecordSentMessage_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
