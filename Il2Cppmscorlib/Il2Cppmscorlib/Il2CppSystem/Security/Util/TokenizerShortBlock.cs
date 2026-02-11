using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x02000227 RID: 551
	public sealed class TokenizerShortBlock : Object
	{
		// Token: 0x0600249B RID: 9371 RVA: 0x000CBBF0 File Offset: 0x000C9DF0
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerShortBlock()
		{
			Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerShortBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr);
			TokenizerShortBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_block");
			TokenizerShortBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, "m_next");
			TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr, 100669457);
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x000CBC5C File Offset: 0x000C9E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370455, XrefRangeEnd = 1370460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerShortBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerShortBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerShortBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		public TokenizerShortBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000CBC98 File Offset: 0x000C9E98
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0000BBE1 File Offset: 0x00009DE1
		public unsafe Il2CppStructArray<short> m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000CBCC8 File Offset: 0x000C9EC8
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0000BC00 File Offset: 0x00009E00
		public unsafe TokenizerShortBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerShortBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
