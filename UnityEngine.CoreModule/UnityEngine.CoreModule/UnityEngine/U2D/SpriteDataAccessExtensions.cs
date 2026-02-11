using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x02000188 RID: 392
	public static class SpriteDataAccessExtensions : Object
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x000864FC File Offset: 0x000846FC
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteDataAccessExtensions()
		{
			Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteDataAccessExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667395);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667396);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667397);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667398);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667399);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667400);
			SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100667401);
			SpriteDataAccessExtensions.HasVertexAttributeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.HasVertexAttributeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::HasVertexAttribute");
			SpriteDataAccessExtensions.SetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount");
			SpriteDataAccessExtensions.GetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount");
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBindPoseDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData");
			SpriteDataAccessExtensions.SetIndicesDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetIndicesDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData");
			SpriteDataAccessExtensions.SetChannelDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetChannelDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData");
			SpriteDataAccessExtensions.GetBoneInfoDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBoneInfoDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo");
			SpriteDataAccessExtensions.SetBoneDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBoneDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData");
			SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize");
			SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBindPoseInfo_Injected");
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00086650 File Offset: 0x00084850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677485, RefRangeEnd = 677486, XrefRangeStart = 677452, XrefRangeEnd = 677485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref channel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00086684 File Offset: 0x00084884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 677494, RefRangeEnd = 677496, XrefRangeStart = 677486, XrefRangeEnd = 677494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, UnityEngine.Rendering.VertexAttribute channel) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeSlice<T>(intPtr);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000866D0 File Offset: 0x000848D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677502, RefRangeEnd = 677503, XrefRangeStart = 677496, XrefRangeEnd = 677502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Unity.Collections.NativeArray<ushort> GetIndices(this Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Unity.Collections.NativeArray<ushort>(intPtr);
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0008670C File Offset: 0x0008490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677503, XrefRangeEnd = 677505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteChannelInfo GetIndicesInfo(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00086750 File Offset: 0x00084950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677507, RefRangeEnd = 677508, XrefRangeStart = 677505, XrefRangeEnd = 677507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteChannelInfo GetChannelInfo(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000867A0 File Offset: 0x000849A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677508, XrefRangeEnd = 677510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x000867E4 File Offset: 0x000849E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677510, XrefRangeEnd = 677512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetChannelInfo_Injected(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, out SpriteChannelInfo ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0000AED7 File Offset: 0x000090D7
		public SpriteDataAccessExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0000AEE0 File Offset: 0x000090E0
		public static void SetVertexAttribute<T>(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00086838 File Offset: 0x00084A38
		public static Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite)
		{
			SpriteChannelInfo bindPoseInfo = SpriteDataAccessExtensions.GetBindPoseInfo(sprite);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>(bindPoseInfo.buffer, bindPoseInfo.count, Unity.Collections.Allocator.None);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0000AEF8 File Offset: 0x000090F8
		public static void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src)
		{
			SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), src.Length);
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0000AF0F File Offset: 0x0000910F
		public static void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src)
		{
			SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), src.Length);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00086868 File Offset: 0x00084A68
		public static Il2CppReferenceArray<SpriteBone> GetBones(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetBoneInfo(sprite);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0000AF26 File Offset: 0x00009126
		public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneData(sprite, src);
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0000AF31 File Offset: 0x00009131
		public static bool HasVertexAttribute(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			return SpriteDataAccessExtensions.HasVertexAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0000AF44 File Offset: 0x00009144
		public static void SetVertexCount(Sprite sprite, int count)
		{
			SpriteDataAccessExtensions.SetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), count);
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0000AF57 File Offset: 0x00009157
		public static int GetVertexCount(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00086880 File Offset: 0x00084A80
		public static SpriteChannelInfo GetBindPoseInfo(Sprite sprite)
		{
			SpriteChannelInfo spriteChannelInfo;
			SpriteDataAccessExtensions.GetBindPoseInfo_Injected(sprite, out spriteChannelInfo);
			return spriteChannelInfo;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0000AF69 File Offset: 0x00009169
		public unsafe static void SetBindPoseData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0000AF7D File Offset: 0x0000917D
		public unsafe static void SetIndicesData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetIndicesDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0000AF91 File Offset: 0x00009191
		public unsafe static void SetChannelData(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, void* src)
		{
			SpriteDataAccessExtensions.SetChannelDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel, src);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00086898 File Offset: 0x00084A98
		public static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
		{
			IntPtr intPtr = SpriteDataAccessExtensions.GetBoneInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x0000AFA5 File Offset: 0x000091A5
		public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(src));
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0000AFBD File Offset: 0x000091BD
		public static int GetPrimaryVertexStreamSize(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0000AFCF File Offset: 0x000091CF
		public static void GetBindPoseInfo_Injected(Sprite sprite, out SpriteChannelInfo ret)
		{
			SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), out ret);
		}

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0;

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_Sprite_byref_SpriteChannelInfo_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_Sprite_VertexAttribute_byref_SpriteChannelInfo_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly SpriteDataAccessExtensions.HasVertexAttributeDelegate HasVertexAttributeDelegateField;

		// Token: 0x04001A01 RID: 6657
		private static readonly SpriteDataAccessExtensions.SetVertexCountDelegate SetVertexCountDelegateField;

		// Token: 0x04001A02 RID: 6658
		private static readonly SpriteDataAccessExtensions.GetVertexCountDelegate GetVertexCountDelegateField;

		// Token: 0x04001A03 RID: 6659
		private static readonly SpriteDataAccessExtensions.SetBindPoseDataDelegate SetBindPoseDataDelegateField;

		// Token: 0x04001A04 RID: 6660
		private static readonly SpriteDataAccessExtensions.SetIndicesDataDelegate SetIndicesDataDelegateField;

		// Token: 0x04001A05 RID: 6661
		private static readonly SpriteDataAccessExtensions.SetChannelDataDelegate SetChannelDataDelegateField;

		// Token: 0x04001A06 RID: 6662
		private static readonly SpriteDataAccessExtensions.GetBoneInfoDelegate GetBoneInfoDelegateField;

		// Token: 0x04001A07 RID: 6663
		private static readonly SpriteDataAccessExtensions.SetBoneDataDelegate SetBoneDataDelegateField;

		// Token: 0x04001A08 RID: 6664
		private static readonly SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate GetPrimaryVertexStreamSizeDelegateField;

		// Token: 0x04001A09 RID: 6665
		private static readonly SpriteDataAccessExtensions.GetBindPoseInfo_InjectedDelegate GetBindPoseInfo_InjectedDelegateField;

		// Token: 0x02000801 RID: 2049
		private sealed class MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>
		{
			// Token: 0x04002CB7 RID: 11447
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpriteDataAccessExtensions.NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000802 RID: 2050
		private sealed class MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>
		{
			// Token: 0x04002CB8 RID: 11448
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SpriteDataAccessExtensions.NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000803 RID: 2051
		// (Invoke) Token: 0x060038B6 RID: 14518
		private delegate bool HasVertexAttributeDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel);

		// Token: 0x02000804 RID: 2052
		// (Invoke) Token: 0x060038B8 RID: 14520
		private delegate void SetVertexCountDelegate(IntPtr sprite, int count);

		// Token: 0x02000805 RID: 2053
		// (Invoke) Token: 0x060038BA RID: 14522
		private delegate int GetVertexCountDelegate(IntPtr sprite);

		// Token: 0x02000806 RID: 2054
		// (Invoke) Token: 0x060038BC RID: 14524
		private delegate void SetBindPoseDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000807 RID: 2055
		// (Invoke) Token: 0x060038BE RID: 14526
		private delegate void SetIndicesDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000808 RID: 2056
		// (Invoke) Token: 0x060038C0 RID: 14528
		private delegate void SetChannelDataDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel, IntPtr src);

		// Token: 0x02000809 RID: 2057
		// (Invoke) Token: 0x060038C2 RID: 14530
		private delegate IntPtr GetBoneInfoDelegate(IntPtr sprite);

		// Token: 0x0200080A RID: 2058
		// (Invoke) Token: 0x060038C4 RID: 14532
		private delegate void SetBoneDataDelegate(IntPtr sprite, IntPtr src);

		// Token: 0x0200080B RID: 2059
		// (Invoke) Token: 0x060038C6 RID: 14534
		private delegate int GetPrimaryVertexStreamSizeDelegate(IntPtr sprite);

		// Token: 0x0200080C RID: 2060
		// (Invoke) Token: 0x060038C8 RID: 14536
		private delegate void GetBindPoseInfo_InjectedDelegate(IntPtr sprite, [Out] IntPtr ret);
	}
}
