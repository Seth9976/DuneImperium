using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class UnitySingleton<T> : global::Il2CppSystem.Object where T : MonoBehaviour
{
	// Token: 0x060002A2 RID: 674 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
	// Note: this type is marked as 'beforefieldinit'.
	static UnitySingleton()
	{
		Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "UnitySingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr);
		UnitySingleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, "_instance");
		UnitySingleton<T>.NativeFieldInfoPtr__myType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, "_myType");
		UnitySingleton<T>.NativeFieldInfoPtr__autoCreatePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, "_autoCreatePrefab");
		UnitySingleton<T>.NativeFieldInfoPtr__GlobalInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, "_GlobalInstanceCount");
		UnitySingleton<T>.NativeFieldInfoPtr__awakeSingletonCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, "_awakeSingletonCalled");
		UnitySingleton<T>.NativeMethodInfoPtr_GetSingleton_Public_Static_T_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, 100663656);
		UnitySingleton<T>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, 100663657);
		UnitySingleton<T>.NativeMethodInfoPtr__Awake_Internal_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, 100663658);
		UnitySingleton<T>.NativeMethodInfoPtr__Destroy_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, 100663659);
		UnitySingleton<T>.NativeMethodInfoPtr__AwakeSingleton_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr, 100663660);
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0001D01C File Offset: 0x0001B21C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 853677, RefRangeEnd = 853680, XrefRangeStart = 853585, XrefRangeEnd = 853677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetSingleton(bool throwErrorIfNotFound, bool autoCreate)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref throwErrorIfNotFound;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCreate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySingleton<T>.NativeMethodInfoPtr_GetSingleton_Public_Static_T_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0001D064 File Offset: 0x0001B264
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnitySingleton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySingleton<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySingleton<T>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853716, RefRangeEnd = 853717, XrefRangeStart = 853680, XrefRangeEnd = 853716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _Awake(T instance)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = instance;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref instance;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnitySingleton<T>.NativeMethodInfoPtr__Awake_Internal_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0001D10C File Offset: 0x0001B30C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853738, RefRangeEnd = 853739, XrefRangeStart = 853717, XrefRangeEnd = 853738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _Destroy()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySingleton<T>.NativeMethodInfoPtr__Destroy_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0001D134 File Offset: 0x0001B334
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 853752, RefRangeEnd = 853755, XrefRangeStart = 853739, XrefRangeEnd = 853752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _AwakeSingleton(T instance)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = instance;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref instance;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnitySingleton<T>.NativeMethodInfoPtr__AwakeSingleton_Private_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x000031D4 File Offset: 0x000013D4
	public UnitySingleton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
	// (set) Token: 0x060002AA RID: 682 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
	public unsafe static T _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UnitySingleton<T>.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
		}
		set
		{
			IntPtr nativeFieldInfoPtr__instance = UnitySingleton<T>.NativeFieldInfoPtr__instance;
			ref T ptr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					if ((ref ptr) != null)
					{
						ptr2 = ref ptr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
						{
							ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
						}
					}
				}
				else
				{
					ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr2 = ref value;
			}
			IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__instance, (void*)(&ptr2));
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060002AB RID: 683 RVA: 0x0001D22C File Offset: 0x0001B42C
	// (set) Token: 0x060002AC RID: 684 RVA: 0x000031DD File Offset: 0x000013DD
	public unsafe static Type _myType
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UnitySingleton<T>.NativeFieldInfoPtr__myType, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UnitySingleton<T>.NativeFieldInfoPtr__myType, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060002AD RID: 685 RVA: 0x0001D254 File Offset: 0x0001B454
	// (set) Token: 0x060002AE RID: 686 RVA: 0x000031EF File Offset: 0x000013EF
	public unsafe static GameObject _autoCreatePrefab
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UnitySingleton<T>.NativeFieldInfoPtr__autoCreatePrefab, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UnitySingleton<T>.NativeFieldInfoPtr__autoCreatePrefab, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060002AF RID: 687 RVA: 0x0001D27C File Offset: 0x0001B47C
	// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003201 File Offset: 0x00001401
	public unsafe static int _GlobalInstanceCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(UnitySingleton<T>.NativeFieldInfoPtr__GlobalInstanceCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UnitySingleton<T>.NativeFieldInfoPtr__GlobalInstanceCount, (void*)(&value));
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001D298 File Offset: 0x0001B498
	// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000320F File Offset: 0x0000140F
	public unsafe static bool _awakeSingletonCalled
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(UnitySingleton<T>.NativeFieldInfoPtr__awakeSingletonCalled, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UnitySingleton<T>.NativeFieldInfoPtr__awakeSingletonCalled, (void*)(&value));
		}
	}

	// Token: 0x040001EF RID: 495
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x040001F0 RID: 496
	private static readonly IntPtr NativeFieldInfoPtr__myType;

	// Token: 0x040001F1 RID: 497
	private static readonly IntPtr NativeFieldInfoPtr__autoCreatePrefab;

	// Token: 0x040001F2 RID: 498
	private static readonly IntPtr NativeFieldInfoPtr__GlobalInstanceCount;

	// Token: 0x040001F3 RID: 499
	private static readonly IntPtr NativeFieldInfoPtr__awakeSingletonCalled;

	// Token: 0x040001F4 RID: 500
	private static readonly IntPtr NativeMethodInfoPtr_GetSingleton_Public_Static_T_Boolean_Boolean_0;

	// Token: 0x040001F5 RID: 501
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	// Token: 0x040001F6 RID: 502
	private static readonly IntPtr NativeMethodInfoPtr__Awake_Internal_Static_Void_T_0;

	// Token: 0x040001F7 RID: 503
	private static readonly IntPtr NativeMethodInfoPtr__Destroy_Internal_Static_Void_0;

	// Token: 0x040001F8 RID: 504
	private static readonly IntPtr NativeMethodInfoPtr__AwakeSingleton_Private_Static_Void_T_0;
}
