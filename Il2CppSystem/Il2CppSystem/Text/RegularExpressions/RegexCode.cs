using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200007F RID: 127
	public sealed class RegexCode : Object
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x0003DB84 File Offset: 0x0003BD84
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCode()
		{
			Il2CppClassPointerStore<RegexCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCode>.NativeClassPtr);
			RegexCode.NativeFieldInfoPtr_Onerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onerep");
			RegexCode.NativeFieldInfoPtr_Notonerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonerep");
			RegexCode.NativeFieldInfoPtr_Setrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setrep");
			RegexCode.NativeFieldInfoPtr_Oneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Oneloop");
			RegexCode.NativeFieldInfoPtr_Notoneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notoneloop");
			RegexCode.NativeFieldInfoPtr_Setloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setloop");
			RegexCode.NativeFieldInfoPtr_Onelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onelazy");
			RegexCode.NativeFieldInfoPtr_Notonelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonelazy");
			RegexCode.NativeFieldInfoPtr_Setlazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setlazy");
			RegexCode.NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "One");
			RegexCode.NativeFieldInfoPtr_Notone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notone");
			RegexCode.NativeFieldInfoPtr_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Set");
			RegexCode.NativeFieldInfoPtr_Multi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Multi");
			RegexCode.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ref");
			RegexCode.NativeFieldInfoPtr_Bol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Bol");
			RegexCode.NativeFieldInfoPtr_Eol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Eol");
			RegexCode.NativeFieldInfoPtr_Boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Boundary");
			RegexCode.NativeFieldInfoPtr_Nonboundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nonboundary");
			RegexCode.NativeFieldInfoPtr_Beginning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Beginning");
			RegexCode.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Start");
			RegexCode.NativeFieldInfoPtr_EndZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "EndZ");
			RegexCode.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "End");
			RegexCode.NativeFieldInfoPtr_Nothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nothing");
			RegexCode.NativeFieldInfoPtr_Lazybranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranch");
			RegexCode.NativeFieldInfoPtr_Branchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchmark");
			RegexCode.NativeFieldInfoPtr_Lazybranchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchmark");
			RegexCode.NativeFieldInfoPtr_Nullcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullcount");
			RegexCode.NativeFieldInfoPtr_Setcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setcount");
			RegexCode.NativeFieldInfoPtr_Branchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchcount");
			RegexCode.NativeFieldInfoPtr_Lazybranchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchcount");
			RegexCode.NativeFieldInfoPtr_Nullmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullmark");
			RegexCode.NativeFieldInfoPtr_Setmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setmark");
			RegexCode.NativeFieldInfoPtr_Capturemark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Capturemark");
			RegexCode.NativeFieldInfoPtr_Getmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Getmark");
			RegexCode.NativeFieldInfoPtr_Setjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setjump");
			RegexCode.NativeFieldInfoPtr_Backjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Backjump");
			RegexCode.NativeFieldInfoPtr_Forejump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Forejump");
			RegexCode.NativeFieldInfoPtr_Testref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Testref");
			RegexCode.NativeFieldInfoPtr_Goto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Goto");
			RegexCode.NativeFieldInfoPtr_Prune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Prune");
			RegexCode.NativeFieldInfoPtr_Stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Stop");
			RegexCode.NativeFieldInfoPtr_ECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "ECMABoundary");
			RegexCode.NativeFieldInfoPtr_NonECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "NonECMABoundary");
			RegexCode.NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Mask");
			RegexCode.NativeFieldInfoPtr_Rtl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Rtl");
			RegexCode.NativeFieldInfoPtr_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back");
			RegexCode.NativeFieldInfoPtr_Back2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back2");
			RegexCode.NativeFieldInfoPtr_Ci = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ci");
			RegexCode.NativeFieldInfoPtr_Codes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Codes");
			RegexCode.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Strings");
			RegexCode.NativeFieldInfoPtr_TrackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "TrackCount");
			RegexCode.NativeFieldInfoPtr_Caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Caps");
			RegexCode.NativeFieldInfoPtr_CapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "CapSize");
			RegexCode.NativeFieldInfoPtr_FCPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "FCPrefix");
			RegexCode.NativeFieldInfoPtr_BMPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "BMPrefix");
			RegexCode.NativeFieldInfoPtr_Anchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Anchors");
			RegexCode.NativeFieldInfoPtr_RightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "RightToLeft");
			RegexCode.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664685);
			RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664686);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0003E050 File Offset: 0x0003C250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440467, RefRangeEnd = 440468, XrefRangeStart = 440458, XrefRangeEnd = 440467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode(Il2CppStructArray<int> codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(codes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringlist);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bmPrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fcPrefix));
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchors;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0003E124 File Offset: 0x0003C324
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 440468, RefRangeEnd = 440473, XrefRangeStart = 440468, XrefRangeEnd = 440468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OpcodeBacktracks(int Op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00004D33 File Offset: 0x00002F33
		public RegexCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0003E164 File Offset: 0x0003C364
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00004D3C File Offset: 0x00002F3C
		public unsafe static int Onerep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Onerep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Onerep, (void*)(&value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0003E180 File Offset: 0x0003C380
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00004D4A File Offset: 0x00002F4A
		public unsafe static int Notonerep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notonerep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notonerep, (void*)(&value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0003E19C File Offset: 0x0003C39C
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00004D58 File Offset: 0x00002F58
		public unsafe static int Setrep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setrep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setrep, (void*)(&value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0003E1B8 File Offset: 0x0003C3B8
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00004D66 File Offset: 0x00002F66
		public unsafe static int Oneloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Oneloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Oneloop, (void*)(&value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00004D74 File Offset: 0x00002F74
		public unsafe static int Notoneloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notoneloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notoneloop, (void*)(&value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0003E1F0 File Offset: 0x0003C3F0
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00004D82 File Offset: 0x00002F82
		public unsafe static int Setloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setloop, (void*)(&value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0003E20C File Offset: 0x0003C40C
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00004D90 File Offset: 0x00002F90
		public unsafe static int Onelazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Onelazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Onelazy, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0003E228 File Offset: 0x0003C428
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x00004D9E File Offset: 0x00002F9E
		public unsafe static int Notonelazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notonelazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notonelazy, (void*)(&value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0003E244 File Offset: 0x0003C444
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00004DAC File Offset: 0x00002FAC
		public unsafe static int Setlazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setlazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setlazy, (void*)(&value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0003E260 File Offset: 0x0003C460
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00004DBA File Offset: 0x00002FBA
		public unsafe static int One
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_One, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_One, (void*)(&value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0003E27C File Offset: 0x0003C47C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00004DC8 File Offset: 0x00002FC8
		public unsafe static int Notone
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notone, (void*)(&value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0003E298 File Offset: 0x0003C498
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00004DD6 File Offset: 0x00002FD6
		public unsafe static int Set
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Set, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Set, (void*)(&value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00004DE4 File Offset: 0x00002FE4
		public unsafe static int Multi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Multi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Multi, (void*)(&value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0003E2D0 File Offset: 0x0003C4D0
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public unsafe static int Ref
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Ref, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Ref, (void*)(&value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00004E00 File Offset: 0x00003000
		public unsafe static int Bol
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Bol, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Bol, (void*)(&value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0003E308 File Offset: 0x0003C508
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00004E0E File Offset: 0x0000300E
		public unsafe static int Eol
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Eol, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Eol, (void*)(&value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0003E324 File Offset: 0x0003C524
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00004E1C File Offset: 0x0000301C
		public unsafe static int Boundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Boundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Boundary, (void*)(&value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0003E340 File Offset: 0x0003C540
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00004E2A File Offset: 0x0000302A
		public unsafe static int Nonboundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nonboundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nonboundary, (void*)(&value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0003E35C File Offset: 0x0003C55C
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00004E38 File Offset: 0x00003038
		public unsafe static int Beginning
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Beginning, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Beginning, (void*)(&value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0003E378 File Offset: 0x0003C578
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00004E46 File Offset: 0x00003046
		public unsafe static int Start
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Start, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Start, (void*)(&value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0003E394 File Offset: 0x0003C594
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00004E54 File Offset: 0x00003054
		public unsafe static int EndZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_EndZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_EndZ, (void*)(&value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00004E62 File Offset: 0x00003062
		public unsafe static int End
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_End, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_End, (void*)(&value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0003E3CC File Offset: 0x0003C5CC
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00004E70 File Offset: 0x00003070
		public unsafe static int Nothing
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nothing, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nothing, (void*)(&value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0003E3E8 File Offset: 0x0003C5E8
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00004E7E File Offset: 0x0000307E
		public unsafe static int Lazybranch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranch, (void*)(&value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0003E404 File Offset: 0x0003C604
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00004E8C File Offset: 0x0000308C
		public unsafe static int Branchmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Branchmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Branchmark, (void*)(&value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0003E420 File Offset: 0x0003C620
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00004E9A File Offset: 0x0000309A
		public unsafe static int Lazybranchmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranchmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranchmark, (void*)(&value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0003E43C File Offset: 0x0003C63C
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00004EA8 File Offset: 0x000030A8
		public unsafe static int Nullcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nullcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nullcount, (void*)(&value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0003E458 File Offset: 0x0003C658
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00004EB6 File Offset: 0x000030B6
		public unsafe static int Setcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setcount, (void*)(&value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0003E474 File Offset: 0x0003C674
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00004EC4 File Offset: 0x000030C4
		public unsafe static int Branchcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Branchcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Branchcount, (void*)(&value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0003E490 File Offset: 0x0003C690
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00004ED2 File Offset: 0x000030D2
		public unsafe static int Lazybranchcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranchcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranchcount, (void*)(&value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0003E4AC File Offset: 0x0003C6AC
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00004EE0 File Offset: 0x000030E0
		public unsafe static int Nullmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nullmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nullmark, (void*)(&value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00004EEE File Offset: 0x000030EE
		public unsafe static int Setmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setmark, (void*)(&value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00004EFC File Offset: 0x000030FC
		public unsafe static int Capturemark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Capturemark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Capturemark, (void*)(&value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0003E500 File Offset: 0x0003C700
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00004F0A File Offset: 0x0000310A
		public unsafe static int Getmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Getmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Getmark, (void*)(&value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0003E51C File Offset: 0x0003C71C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00004F18 File Offset: 0x00003118
		public unsafe static int Setjump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setjump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setjump, (void*)(&value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0003E538 File Offset: 0x0003C738
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00004F26 File Offset: 0x00003126
		public unsafe static int Backjump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Backjump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Backjump, (void*)(&value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0003E554 File Offset: 0x0003C754
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00004F34 File Offset: 0x00003134
		public unsafe static int Forejump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Forejump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Forejump, (void*)(&value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0003E570 File Offset: 0x0003C770
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00004F42 File Offset: 0x00003142
		public unsafe static int Testref
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Testref, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Testref, (void*)(&value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0003E58C File Offset: 0x0003C78C
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00004F50 File Offset: 0x00003150
		public unsafe static int Goto
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Goto, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Goto, (void*)(&value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0003E5A8 File Offset: 0x0003C7A8
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00004F5E File Offset: 0x0000315E
		public unsafe static int Prune
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Prune, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Prune, (void*)(&value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0003E5C4 File Offset: 0x0003C7C4
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00004F6C File Offset: 0x0000316C
		public unsafe static int Stop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Stop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Stop, (void*)(&value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00004F7A File Offset: 0x0000317A
		public unsafe static int ECMABoundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_ECMABoundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_ECMABoundary, (void*)(&value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0003E5FC File Offset: 0x0003C7FC
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00004F88 File Offset: 0x00003188
		public unsafe static int NonECMABoundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_NonECMABoundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_NonECMABoundary, (void*)(&value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0003E618 File Offset: 0x0003C818
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00004F96 File Offset: 0x00003196
		public unsafe static int Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Mask, (void*)(&value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0003E634 File Offset: 0x0003C834
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00004FA4 File Offset: 0x000031A4
		public unsafe static int Rtl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Rtl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Rtl, (void*)(&value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0003E650 File Offset: 0x0003C850
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00004FB2 File Offset: 0x000031B2
		public unsafe static int Back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Back, (void*)(&value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003E66C File Offset: 0x0003C86C
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00004FC0 File Offset: 0x000031C0
		public unsafe static int Back2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Back2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Back2, (void*)(&value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0003E688 File Offset: 0x0003C888
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00004FCE File Offset: 0x000031CE
		public unsafe static int Ci
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Ci, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Ci, (void*)(&value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00004FDC File Offset: 0x000031DC
		public unsafe Il2CppStructArray<int> Codes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Codes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Codes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0003E6D4 File Offset: 0x0003C8D4
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00004FFB File Offset: 0x000031FB
		public unsafe Il2CppStringArray Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0003E704 File Offset: 0x0003C904
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0000501A File Offset: 0x0000321A
		public unsafe int TrackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_TrackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_TrackCount)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0003E72C File Offset: 0x0003C92C
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00005035 File Offset: 0x00003235
		public unsafe Hashtable Caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0003E75C File Offset: 0x0003C95C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00005054 File Offset: 0x00003254
		public unsafe int CapSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_CapSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_CapSize)) = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0003E784 File Offset: 0x0003C984
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x0000506F File Offset: 0x0000326F
		public Nullable<RegexPrefix> FCPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_FCPrefix);
				return new Nullable<RegexPrefix>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RegexPrefix>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_FCPrefix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RegexPrefix>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x0000509D File Offset: 0x0000329D
		public unsafe RegexBoyerMoore BMPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_BMPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_BMPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0003E7E4 File Offset: 0x0003C9E4
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000050BC File Offset: 0x000032BC
		public unsafe int Anchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Anchors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_Anchors)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0003E80C File Offset: 0x0003CA0C
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x000050D7 File Offset: 0x000032D7
		public unsafe bool RightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_RightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr_RightToLeft)) = value;
			}
		}

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeFieldInfoPtr_Onerep;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeFieldInfoPtr_Notonerep;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_Setrep;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_Oneloop;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_Notoneloop;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_Setloop;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_Onelazy;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_Notonelazy;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_Setlazy;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_One;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_Notone;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_Set;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_Multi;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_Bol;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_Eol;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_Boundary;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_Nonboundary;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_Beginning;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_EndZ;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_Nothing;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranch;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_Branchmark;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranchmark;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_Nullcount;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_Setcount;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_Branchcount;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranchcount;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_Nullmark;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_Setmark;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_Capturemark;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_Getmark;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_Setjump;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_Backjump;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_Forejump;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_Testref;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_Goto;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_Prune;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_Stop;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_ECMABoundary;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_NonECMABoundary;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_Mask;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_Rtl;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_Back;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_Back2;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_Ci;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_Codes;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_TrackCount;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_Caps;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_CapSize;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_FCPrefix;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_BMPrefix;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_Anchors;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_RightToLeft;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0;
	}
}
