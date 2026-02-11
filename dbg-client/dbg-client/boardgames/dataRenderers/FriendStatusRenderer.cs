using System;
using boardgames.data;
using boardgames.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014E RID: 334
	public class FriendStatusRenderer : Subscriber<FriendStatusData>
	{
		// Token: 0x06000F1C RID: 3868 RVA: 0x0004DBB4 File Offset: 0x0004BDB4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendStatusRenderer()
		{
			Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FriendStatusRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr);
			FriendStatusRenderer.NativeFieldInfoPtr_friendStatusIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr, "friendStatusIcons");
			FriendStatusRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr, 100665487);
			FriendStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr, 100665488);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0004DC20 File Offset: 0x0004BE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513062, XrefRangeEnd = 513068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendStatusRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0004DC5C File Offset: 0x0004BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513068, XrefRangeEnd = 513078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendStatusRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendStatusRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00009424 File Offset: 0x00007624
		public FriendStatusRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x0004DC98 File Offset: 0x0004BE98
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x0000942D File Offset: 0x0000762D
		public unsafe Il2CppReferenceArray<FriendStatusRenderer.FriendStatusIcons> friendStatusIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.NativeFieldInfoPtr_friendStatusIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FriendStatusRenderer.FriendStatusIcons>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.NativeFieldInfoPtr_friendStatusIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_friendStatusIcons;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200036C RID: 876
		[Serializable]
		public sealed class FriendStatusIcons : ValueType
		{
			// Token: 0x06002943 RID: 10563 RVA: 0x000A401C File Offset: 0x000A221C
			// Note: this type is marked as 'beforefieldinit'.
			static FriendStatusIcons()
			{
				Il2CppClassPointerStore<FriendStatusRenderer.FriendStatusIcons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendStatusRenderer>.NativeClassPtr, "FriendStatusIcons");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendStatusRenderer.FriendStatusIcons>.NativeClassPtr);
				FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_statusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendStatusRenderer.FriendStatusIcons>.NativeClassPtr, "statusList");
				FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendStatusRenderer.FriendStatusIcons>.NativeClassPtr, "icon");
			}

			// Token: 0x06002944 RID: 10564 RVA: 0x000154F1 File Offset: 0x000136F1
			public FriendStatusIcons(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002945 RID: 10565 RVA: 0x000154FA File Offset: 0x000136FA
			public FriendStatusIcons()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendStatusRenderer.FriendStatusIcons>.NativeClassPtr))
			{
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x06002946 RID: 10566 RVA: 0x000A4070 File Offset: 0x000A2270
			// (set) Token: 0x06002947 RID: 10567 RVA: 0x0001550C File Offset: 0x0001370C
			public unsafe List<DBGConstants.FriendStatuses> statusList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_statusList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DBGConstants.FriendStatuses>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_statusList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x06002948 RID: 10568 RVA: 0x000A40A0 File Offset: 0x000A22A0
			// (set) Token: 0x06002949 RID: 10569 RVA: 0x0001552B File Offset: 0x0001372B
			public unsafe GameObject icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusRenderer.FriendStatusIcons.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019CB RID: 6603
			private static readonly IntPtr NativeFieldInfoPtr_statusList;

			// Token: 0x040019CC RID: 6604
			private static readonly IntPtr NativeFieldInfoPtr_icon;
		}
	}
}
