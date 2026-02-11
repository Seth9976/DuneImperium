using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct ProfilerCategory
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00018288 File Offset: 0x00016488
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerCategory()
		{
			Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr);
			ProfilerCategory.NativeFieldInfoPtr_m_CategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, "m_CategoryId");
			ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663361);
			ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663362);
			ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663363);
			ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663364);
			ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00018330 File Offset: 0x00016530
		[CallerCount(0)]
		public unsafe ProfilerCategory(ushort category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00018364 File Offset: 0x00016564
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 643175, RefRangeEnd = 643176, XrefRangeStart = 643164, XrefRangeEnd = 643175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00018390 File Offset: 0x00016590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643176, XrefRangeEnd = 643177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000183BC File Offset: 0x000165BC
		public unsafe static ProfilerCategory Scripts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000183EC File Offset: 0x000165EC
		[CallerCount(0)]
		public unsafe static implicit operator ushort(ProfilerCategory category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024B7 File Offset: 0x000006B7
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, ref this));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000024C9 File Offset: 0x000006C9
		public global::UnityEngine.Color32 Color
		{
			get
			{
				return Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.GetCategoryDescription(this.m_CategoryId).Color;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000024DB File Offset: 0x000006DB
		public static ProfilerCategory Render
		{
			get
			{
				return new ProfilerCategory(0);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000024E3 File Offset: 0x000006E3
		public static ProfilerCategory Gui
		{
			get
			{
				return new ProfilerCategory(4);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000024EB File Offset: 0x000006EB
		public static ProfilerCategory Physics
		{
			get
			{
				return new ProfilerCategory(5);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000024F3 File Offset: 0x000006F3
		public static ProfilerCategory Physics2D
		{
			get
			{
				return new ProfilerCategory(33);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000024FC File Offset: 0x000006FC
		public static ProfilerCategory Animation
		{
			get
			{
				return new ProfilerCategory(6);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002504 File Offset: 0x00000704
		public static ProfilerCategory Ai
		{
			get
			{
				return new ProfilerCategory(7);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000250C File Offset: 0x0000070C
		public static ProfilerCategory Audio
		{
			get
			{
				return new ProfilerCategory(8);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002514 File Offset: 0x00000714
		public static ProfilerCategory Video
		{
			get
			{
				return new ProfilerCategory(11);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000251D File Offset: 0x0000071D
		public static ProfilerCategory Particles
		{
			get
			{
				return new ProfilerCategory(12);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002526 File Offset: 0x00000726
		public static ProfilerCategory Lighting
		{
			get
			{
				return new ProfilerCategory(13);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000252F File Offset: 0x0000072F
		public static ProfilerCategory Network
		{
			get
			{
				return new ProfilerCategory(14);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002538 File Offset: 0x00000738
		public static ProfilerCategory Loading
		{
			get
			{
				return new ProfilerCategory(15);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002541 File Offset: 0x00000741
		public static ProfilerCategory Vr
		{
			get
			{
				return new ProfilerCategory(22);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000254A File Offset: 0x0000074A
		public static ProfilerCategory Input
		{
			get
			{
				return new ProfilerCategory(30);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002553 File Offset: 0x00000753
		public static ProfilerCategory Memory
		{
			get
			{
				return new ProfilerCategory(23);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000255C File Offset: 0x0000075C
		public static ProfilerCategory VirtualTexturing
		{
			get
			{
				return new ProfilerCategory(31);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002565 File Offset: 0x00000765
		public static ProfilerCategory FileIO
		{
			get
			{
				return new ProfilerCategory(25);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000256E File Offset: 0x0000076E
		public static ProfilerCategory Internal
		{
			get
			{
				return new ProfilerCategory(24);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002577 File Offset: 0x00000777
		public static ProfilerCategory Any
		{
			get
			{
				return new ProfilerCategory(ushort.MaxValue);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002583 File Offset: 0x00000783
		public static ProfilerCategory GPU
		{
			get
			{
				return new ProfilerCategory(32);
			}
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_m_CategoryId;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0;

		// Token: 0x04000066 RID: 102
		[FieldOffset(0)]
		public readonly ushort m_CategoryId;
	}
}
