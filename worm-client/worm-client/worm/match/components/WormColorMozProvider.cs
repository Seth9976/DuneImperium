using System;
using boardgames.match.behaviours;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001DA RID: 474
	public class WormColorMozProvider : MonoBehaviour
	{
		// Token: 0x060014F9 RID: 5369 RVA: 0x00057C04 File Offset: 0x00055E04
		// Note: this type is marked as 'beforefieldinit'.
		static WormColorMozProvider()
		{
			Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormColorMozProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr);
			WormColorMozProvider.NativeFieldInfoPtr_colorProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, "colorProvider");
			WormColorMozProvider.NativeFieldInfoPtr_mozEntityNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, "mozEntityNames");
			WormColorMozProvider.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, "entitiesProvider");
			WormColorMozProvider.NativeFieldInfoPtr_currentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, "currentEntityID");
			WormColorMozProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, 100666164);
			WormColorMozProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, 100666165);
			WormColorMozProvider.NativeMethodInfoPtr_OnMozBegin_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, 100666166);
			WormColorMozProvider.NativeMethodInfoPtr_OnMozEnd_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, 100666167);
			WormColorMozProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr, 100666168);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00057CE8 File Offset: 0x00055EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714556, XrefRangeEnd = 714596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorMozProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00057D1C File Offset: 0x00055F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714596, XrefRangeEnd = 714615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorMozProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00057D50 File Offset: 0x00055F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714615, XrefRangeEnd = 714653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMozBegin(string entityIDString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorMozProvider.NativeMethodInfoPtr_OnMozBegin_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00057D94 File Offset: 0x00055F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714653, XrefRangeEnd = 714667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMozEnd(string entityIDString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entityIDString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorMozProvider.NativeMethodInfoPtr_OnMozEnd_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00057DD8 File Offset: 0x00055FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714667, XrefRangeEnd = 714672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormColorMozProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormColorMozProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormColorMozProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0000CCC9 File Offset: 0x0000AEC9
		public WormColorMozProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00057E14 File Offset: 0x00056014
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000CCD2 File Offset: 0x0000AED2
		public unsafe SubscriptionProvider colorProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_colorProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_colorProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00057E44 File Offset: 0x00056044
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0000CCF1 File Offset: 0x0000AEF1
		public unsafe Il2CppStringArray mozEntityNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_mozEntityNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_mozEntityNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00057E74 File Offset: 0x00056074
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x0000CD10 File Offset: 0x0000AF10
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x00057EA4 File Offset: 0x000560A4
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x0000CD2F File Offset: 0x0000AF2F
		public unsafe EntityID currentEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_currentEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormColorMozProvider.NativeFieldInfoPtr_currentEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr_colorProvider;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_mozEntityNames;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_currentEntityID;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_OnMozBegin_Private_Void_String_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_OnMozEnd_Private_Void_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
