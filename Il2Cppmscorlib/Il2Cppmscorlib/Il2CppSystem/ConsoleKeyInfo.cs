using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000116 RID: 278
	[Serializable]
	[StructLayout(2)]
	public struct ConsoleKeyInfo
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0007E360 File Offset: 0x0007C560
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleKeyInfo()
		{
			Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleKeyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr);
			ConsoleKeyInfo.NativeFieldInfoPtr__keyChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_keyChar");
			ConsoleKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_key");
			ConsoleKeyInfo.NativeFieldInfoPtr__mods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_mods");
			ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666495);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666496);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666497);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666498);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666499);
			ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100666500);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0007E444 File Offset: 0x0007C644
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1333707, RefRangeEnd = 1333770, XrefRangeStart = 1333707, XrefRangeEnd = 1333707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0007E4B0 File Offset: 0x0007C6B0
		public unsafe char KeyChar
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 638989, RefRangeEnd = 639002, XrefRangeStart = 638989, XrefRangeEnd = 639002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0007E4E0 File Offset: 0x0007C6E0
		public unsafe ConsoleKey Key
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0007E510 File Offset: 0x0007C710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333770, XrefRangeEnd = 1333773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0007E554 File Offset: 0x0007C754
		[CallerCount(0)]
		public unsafe bool Equals(ConsoleKeyInfo obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0007E594 File Offset: 0x0007C794
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00006162 File Offset: 0x00004362
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr__keyChar;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr__mods;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FA9 RID: 4009
		[FieldOffset(0)]
		public readonly char _keyChar;

		// Token: 0x04000FAA RID: 4010
		[FieldOffset(4)]
		public readonly ConsoleKey _key;

		// Token: 0x04000FAB RID: 4011
		[FieldOffset(8)]
		public readonly ConsoleModifiers _mods;
	}
}
