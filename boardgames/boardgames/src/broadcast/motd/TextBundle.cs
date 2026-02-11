using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.src.broadcast.motd
{
	// Token: 0x0200015A RID: 346
	public class TextBundle : Object
	{
		// Token: 0x0600119A RID: 4506 RVA: 0x000472D0 File Offset: 0x000454D0
		// Note: this type is marked as 'beforefieldinit'.
		static TextBundle()
		{
			Il2CppClassPointerStore<TextBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.src.broadcast.motd", "TextBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextBundle>.NativeClassPtr);
			TextBundle.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBundle>.NativeClassPtr, "Token");
			TextBundle.NativeFieldInfoPtr_Bundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBundle>.NativeClassPtr, "Bundle");
			TextBundle.NativeMethodInfoPtr_get_Text_Public_get_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundle>.NativeClassPtr, 100665894);
			TextBundle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundle>.NativeClassPtr, 100665895);
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00047350 File Offset: 0x00045550
		public unsafe LocalizableText Text
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1000262, RefRangeEnd = 1000272, XrefRangeStart = 1000243, XrefRangeEnd = 1000262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundle.NativeMethodInfoPtr_get_Text_Public_get_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00047390 File Offset: 0x00045590
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextBundle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextBundle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0000A352 File Offset: 0x00008552
		public TextBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000473CC File Offset: 0x000455CC
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000A35B File Offset: 0x0000855B
		public unsafe string Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundle.NativeFieldInfoPtr_Token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundle.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000473F4 File Offset: 0x000455F4
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0000A37A File Offset: 0x0000857A
		public unsafe Dictionary<string, string> Bundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundle.NativeFieldInfoPtr_Bundle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundle.NativeFieldInfoPtr_Bundle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_Bundle;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_LocalizableText_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
