using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200000F RID: 15
public class HashSet_Flash<T> : HashSet<T>
{
	// Token: 0x0600023C RID: 572 RVA: 0x0001B8EC File Offset: 0x00019AEC
	// Note: this type is marked as 'beforefieldinit'.
	static HashSet_Flash()
	{
		Il2CppClassPointerStore<HashSet_Flash<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "HashSet_Flash`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet_Flash<T>>.NativeClassPtr);
		HashSet_Flash<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet_Flash<T>>.NativeClassPtr, 100663595);
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0001B96C File Offset: 0x00019B6C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852835, RefRangeEnd = 852836, XrefRangeStart = 852827, XrefRangeEnd = 852835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet_Flash()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet_Flash<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet_Flash<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002F45 File Offset: 0x00001145
	public HashSet_Flash(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001AE RID: 430
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
