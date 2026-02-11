using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x02000228 RID: 552
	public sealed class TokenizerStringBlock : Object
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x000CBCF8 File Offset: 0x000C9EF8
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStringBlock()
		{
			Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStringBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr);
			TokenizerStringBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_block");
			TokenizerStringBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_next");
			TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, 100669458);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000CBD64 File Offset: 0x000C9F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370460, XrefRangeEnd = 1370465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStringBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0000BC1F File Offset: 0x00009E1F
		public TokenizerStringBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000CBDA0 File Offset: 0x000C9FA0
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0000BC28 File Offset: 0x00009E28
		public unsafe Il2CppStringArray m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000CBDD0 File Offset: 0x000C9FD0
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x0000BC47 File Offset: 0x00009E47
		public unsafe TokenizerStringBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
