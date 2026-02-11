using System;
using Canis.messages.effect;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000010 RID: 16
public class SequenceEffect<T> : Command where T : EffectMessage
{
	// Token: 0x06000098 RID: 152 RVA: 0x00012850 File Offset: 0x00010A50
	// Note: this type is marked as 'beforefieldinit'.
	static SequenceEffect()
	{
		Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("boardgames.dll", "", "SequenceEffect`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr);
		SequenceEffect<T>.NativeFieldInfoPtr_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr, "Effect");
		SequenceEffect<T>.NativeMethodInfoPtr__ctor_Public_Void_EffectMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr, 100663417);
		SequenceEffect<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr, 100663418);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000128F8 File Offset: 0x00010AF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982770, XrefRangeEnd = 982776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SequenceEffect(EffectMessage effect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceEffect<T>.NativeMethodInfoPtr__ctor_Public_Void_EffectMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00012944 File Offset: 0x00010B44
	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SequenceEffect(T effect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEffect<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = effect;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref effect;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceEffect<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000023B9 File Offset: 0x000005B9
	public SequenceEffect(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600009C RID: 156 RVA: 0x000129C8 File Offset: 0x00010BC8
	// (set) Token: 0x0600009D RID: 157 RVA: 0x000129F0 File Offset: 0x00010BF0
	public unsafe T Effect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceEffect<T>.NativeFieldInfoPtr_Effect);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceEffect<T>.NativeFieldInfoPtr_Effect);
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					IntPtr intPtr4;
					IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
					if (intPtr3 != 0)
					{
						intPtr4 = intPtr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
						{
							IntPtr intPtr5 = intPtr3;
							cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
							return;
						}
					}
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				*intPtr2 = value;
			}
		}
	}

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeFieldInfoPtr_Effect;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EffectMessage_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;
}
