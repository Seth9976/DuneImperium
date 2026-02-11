using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B9 RID: 185
	public class FriendOnlineStatusRenderer : Subscriber<FriendOnlineStatusData>
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x000353AC File Offset: 0x000335AC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendOnlineStatusRenderer()
		{
			Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "FriendOnlineStatusRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr);
			FriendOnlineStatusRenderer.NativeFieldInfoPtr_onlineStatusIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr, "onlineStatusIcon");
			FriendOnlineStatusRenderer.NativeFieldInfoPtr_offlineStatusIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr, "offlineStatusIcon");
			FriendOnlineStatusRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr, 100664439);
			FriendOnlineStatusRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr, 100664440);
			FriendOnlineStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr, 100664441);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00035440 File Offset: 0x00033640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504379, XrefRangeEnd = 504382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendOnlineStatusRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0003547C File Offset: 0x0003367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504382, XrefRangeEnd = 504386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendOnlineStatusRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000354B8 File Offset: 0x000336B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504386, XrefRangeEnd = 504389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendOnlineStatusRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendOnlineStatusRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendOnlineStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000582C File Offset: 0x00003A2C
		public FriendOnlineStatusRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000354F4 File Offset: 0x000336F4
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00005835 File Offset: 0x00003A35
		public unsafe GameObject onlineStatusIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusRenderer.NativeFieldInfoPtr_onlineStatusIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusRenderer.NativeFieldInfoPtr_onlineStatusIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00035524 File Offset: 0x00033724
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00005854 File Offset: 0x00003A54
		public unsafe GameObject offlineStatusIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusRenderer.NativeFieldInfoPtr_offlineStatusIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusRenderer.NativeFieldInfoPtr_offlineStatusIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_onlineStatusIcon;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_offlineStatusIcon;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
