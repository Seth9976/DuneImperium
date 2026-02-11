using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.messages
{
	// Token: 0x0200002D RID: 45
	public class GameNameScorePair : Object
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00009CA4 File Offset: 0x00007EA4
		// Note: this type is marked as 'beforefieldinit'.
		static GameNameScorePair()
		{
			Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "GameNameScorePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr);
			GameNameScorePair.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr, "Name");
			GameNameScorePair.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr, "Score");
			GameNameScorePair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr, 100663374);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009D10 File Offset: 0x00007F10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameNameScorePair(string name, int score)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameNameScorePair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameNameScorePair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000302D File Offset: 0x0000122D
		public GameNameScorePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00009D6C File Offset: 0x00007F6C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00003036 File Offset: 0x00001236
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameNameScorePair.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameNameScorePair.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00009D94 File Offset: 0x00007F94
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00003055 File Offset: 0x00001255
		public unsafe int Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameNameScorePair.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameNameScorePair.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
