using System;
using Canis.entities;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.obfuscation
{
	// Token: 0x02000064 RID: 100
	public class MessageObfuscator<T> : Object where T : NetworkMessageEvent
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0002F54C File Offset: 0x0002D74C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageObfuscator()
		{
			Il2CppClassPointerStore<MessageObfuscator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "MessageObfuscator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageObfuscator<T>>.NativeClassPtr);
			MessageObfuscator<T>.NativeMethodInfoPtr_Obfuscate_Public_Abstract_Virtual_New_IEnumerable_1_NetworkMessageEvent_T_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageObfuscator<T>>.NativeClassPtr, 100664454);
			MessageObfuscator<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageObfuscator<T>>.NativeClassPtr, 100664455);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		[CallerCount(0)]
		public unsafe virtual IEnumerable<NetworkMessageEvent> Obfuscate(T message, Match match, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = message;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref message;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageObfuscator<T>.NativeMethodInfoPtr_Obfuscate_Public_Abstract_Virtual_New_IEnumerable_1_NetworkMessageEvent_T_Match_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr4) : null;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002F698 File Offset: 0x0002D898
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageObfuscator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageObfuscator<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageObfuscator<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000046D5 File Offset: 0x000028D5
		public MessageObfuscator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Public_Abstract_Virtual_New_IEnumerable_1_NetworkMessageEvent_T_Match_PlayerEntity_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
