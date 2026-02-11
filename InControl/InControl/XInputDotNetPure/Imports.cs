using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x02000003 RID: 3
	public class Imports : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000073E8 File Offset: 0x000055E8
		// Note: this type is marked as 'beforefieldinit'.
		static Imports()
		{
			Il2CppClassPointerStore<Imports>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "Imports");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Imports>.NativeClassPtr);
			Imports.NativeMethodInfoPtr_XInputGamePadGetState32_Public_Static_UInt32_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663299);
			Imports.NativeMethodInfoPtr_XInputGamePadSetState32_Public_Static_Void_UInt32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663300);
			Imports.NativeMethodInfoPtr_XInputGamePadGetState64_Public_Static_UInt32_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663301);
			Imports.NativeMethodInfoPtr_XInputGamePadSetState64_Public_Static_Void_UInt32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663302);
			Imports.NativeMethodInfoPtr_XInputGamePadGetState_Public_Static_UInt32_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663303);
			Imports.NativeMethodInfoPtr_XInputGamePadSetState_Public_Static_Void_UInt32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663304);
			Imports.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Imports>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000074A4 File Offset: 0x000056A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767531, XrefRangeEnd = 767533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint XInputGamePadGetState32(uint playerIndex, IntPtr state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadGetState32_Public_Static_UInt32_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000074F0 File Offset: 0x000056F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767533, XrefRangeEnd = 767535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XInputGamePadSetState32(uint playerIndex, float leftMotor, float rightMotor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadSetState32_Public_Static_Void_UInt32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00007540 File Offset: 0x00005740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767535, XrefRangeEnd = 767537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint XInputGamePadGetState64(uint playerIndex, IntPtr state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadGetState64_Public_Static_UInt32_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000758C File Offset: 0x0000578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767537, XrefRangeEnd = 767539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XInputGamePadSetState64(uint playerIndex, float leftMotor, float rightMotor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadSetState64_Public_Static_Void_UInt32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000075DC File Offset: 0x000057DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767539, XrefRangeEnd = 767542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint XInputGamePadGetState(uint playerIndex, IntPtr state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadGetState_Public_Static_UInt32_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00007628 File Offset: 0x00005828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767548, RefRangeEnd = 767549, XrefRangeStart = 767542, XrefRangeEnd = 767548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void XInputGamePadSetState(uint playerIndex, float leftMotor, float rightMotor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr_XInputGamePadSetState_Public_Static_Void_UInt32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00007678 File Offset: 0x00005878
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Imports()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Imports>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Imports.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002059 File Offset: 0x00000259
		public Imports(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadGetState32_Public_Static_UInt32_UInt32_IntPtr_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadSetState32_Public_Static_Void_UInt32_Single_Single_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadGetState64_Public_Static_UInt32_UInt32_IntPtr_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadSetState64_Public_Static_Void_UInt32_Single_Single_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadGetState_Public_Static_UInt32_UInt32_IntPtr_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_XInputGamePadSetState_Public_Static_Void_UInt32_Single_Single_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
