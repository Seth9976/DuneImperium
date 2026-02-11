using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000189 RID: 393
	public class SpriteAtlasManager : Object
	{
		// Token: 0x06001D63 RID: 7523 RVA: 0x000868C4 File Offset: 0x00084AC4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlasManager()
		{
			Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlasManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr);
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRequested");
			SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRegistered");
			SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100667402);
			SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100667403);
			SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100667404);
			SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100667405);
			SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100667406);
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00086980 File Offset: 0x00084B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677512, XrefRangeEnd = 677516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestAtlas(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000869C4 File Offset: 0x00084BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 677525, RefRangeEnd = 677528, XrefRangeStart = 677516, XrefRangeEnd = 677525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_atlasRegistered(Action<SpriteAtlas> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000869FC File Offset: 0x00084BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677537, RefRangeEnd = 677538, XrefRangeStart = 677528, XrefRangeEnd = 677537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_atlasRegistered(Action<SpriteAtlas> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00086A34 File Offset: 0x00084C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677538, XrefRangeEnd = 677540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00086A6C File Offset: 0x00084C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677540, XrefRangeEnd = 677542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlasManager.NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0000AFE2 File Offset: 0x000091E2
		public SpriteAtlasManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00086AA4 File Offset: 0x00084CA4
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000AFEB File Offset: 0x000091EB
		public unsafe static Action<string, Action<SpriteAtlas>> atlasRequested
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Action<SpriteAtlas>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRequested, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x00086ACC File Offset: 0x00084CCC
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000AFFD File Offset: 0x000091FD
		public unsafe static Action<SpriteAtlas> atlasRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteAtlas>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAtlasManager.NativeFieldInfoPtr_atlasRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0000B00F File Offset: 0x0000920F
		public static void add_atlasRequested(Action<string, Action<SpriteAtlas>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0000B01C File Offset: 0x0000921C
		public static void remove_atlasRequested(Action<string, Action<SpriteAtlas>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr_atlasRequested;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeFieldInfoPtr_atlasRegistered;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0;
	}
}
