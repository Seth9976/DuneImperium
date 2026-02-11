using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000025 RID: 37
	public class MSCompatUnicodeTableUtil : Object
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0002A310 File Offset: 0x00028510
		// Note: this type is marked as 'beforefieldinit'.
		static MSCompatUnicodeTableUtil()
		{
			Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTableUtil");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Ignorable");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Category");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level1");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level2");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level3");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "CjkCHS");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Cjk");
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000028A7 File Offset: 0x00000AA7
		public MSCompatUnicodeTableUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0002A3C4 File Offset: 0x000285C4
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000028B0 File Offset: 0x00000AB0
		public unsafe static CodePointIndexer Ignorable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0002A3EC File Offset: 0x000285EC
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000028C2 File Offset: 0x00000AC2
		public unsafe static CodePointIndexer Category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0002A414 File Offset: 0x00028614
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000028D4 File Offset: 0x00000AD4
		public unsafe static CodePointIndexer Level1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0002A43C File Offset: 0x0002863C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x000028E6 File Offset: 0x00000AE6
		public unsafe static CodePointIndexer Level2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0002A464 File Offset: 0x00028664
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000028F8 File Offset: 0x00000AF8
		public unsafe static CodePointIndexer Level3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0002A48C File Offset: 0x0002868C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000290A File Offset: 0x00000B0A
		public unsafe static CodePointIndexer CjkCHS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0002A4B4 File Offset: 0x000286B4
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000291C File Offset: 0x00000B1C
		public unsafe static CodePointIndexer Cjk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_Ignorable;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_Level1;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_Level2;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_Level3;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_CjkCHS;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_Cjk;
	}
}
