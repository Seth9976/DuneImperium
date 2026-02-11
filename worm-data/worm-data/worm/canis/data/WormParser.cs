using System;
using CanisData;
using CanisData.parsers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace worm.canis.data
{
	// Token: 0x02000006 RID: 6
	public class WormParser : Parser
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000288C File Offset: 0x00000A8C
		// Note: this type is marked as 'beforefieldinit'.
		static WormParser()
		{
			Il2CppClassPointerStore<WormParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data", "WormParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormParser>.NativeClassPtr);
			WormParser.NativeMethodInfoPtr__ctor_Public_Void_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormParser>.NativeClassPtr, 100663303);
			WormParser.NativeMethodInfoPtr_FindParser_Protected_Virtual_SheetParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormParser>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000028E4 File Offset: 0x00000AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241628, XrefRangeEnd = 1241662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormParser(string baseOutputDirectory, StringBuilder processOutput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseOutputDirectory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processOutput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormParser.NativeMethodInfoPtr__ctor_Public_Void_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002944 File Offset: 0x00000B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241662, XrefRangeEnd = 1241699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SheetParser FindParser(string parserName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parserName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormParser.NativeMethodInfoPtr_FindParser_Protected_Virtual_SheetParser_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SheetParser>(intPtr3) : null;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public WormParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_StringBuilder_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_FindParser_Protected_Virtual_SheetParser_String_0;
	}
}
