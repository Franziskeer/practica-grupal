
/**
 * CursoMessageReceiverInOut.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
        package org.example.www.curso;

        /**
        *  CursoMessageReceiverInOut message receiver
        */

        public class CursoMessageReceiverInOut extends org.apache.axis2.receivers.AbstractInOutMessageReceiver{


        public void invokeBusinessLogic(org.apache.axis2.context.MessageContext msgContext, org.apache.axis2.context.MessageContext newMsgContext)
        throws org.apache.axis2.AxisFault{

        try {

        // get the implementation class for the Web Service
        Object obj = getTheImplementationObject(msgContext);

        CursoSkeleton skel = (CursoSkeleton)obj;
        //Out Envelop
        org.apache.axiom.soap.SOAPEnvelope envelope = null;
        //Find the axisOperation that has been set by the Dispatch phase.
        org.apache.axis2.description.AxisOperation op = msgContext.getOperationContext().getAxisOperation();
        if (op == null) {
        throw new org.apache.axis2.AxisFault("Operation is not located, if this is doclit style the SOAP-ACTION should specified via the SOAP Action to use the RawXMLProvider");
        }

        java.lang.String methodName;
        if((op.getName() != null) && ((methodName = org.apache.axis2.util.JavaUtils.xmlNameToJavaIdentifier(op.getName().getLocalPart())) != null)){


        

            if("comprobarFecha".equals(methodName)){
                
                org.example.www.curso.ComprobarFechaResponse comprobarFechaResponse9 = null;
	                        org.example.www.curso.ComprobarFecha wrappedParam =
                                                             (org.example.www.curso.ComprobarFecha)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.curso.ComprobarFecha.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               comprobarFechaResponse9 =
                                                   
                                                   
                                                         skel.comprobarFecha(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), comprobarFechaResponse9, false, new javax.xml.namespace.QName("http://www.example.org/Curso/",
                                                    "comprobarFecha"));
                                    } else 

            if("comprobarPlazas".equals(methodName)){
                
                org.example.www.curso.ComprobarPlazasResponse comprobarPlazasResponse11 = null;
	                        org.example.www.curso.ComprobarPlazas wrappedParam =
                                                             (org.example.www.curso.ComprobarPlazas)fromOM(
                                    msgContext.getEnvelope().getBody().getFirstElement(),
                                    org.example.www.curso.ComprobarPlazas.class,
                                    getEnvelopeNamespaces(msgContext.getEnvelope()));
                                                
                                               comprobarPlazasResponse11 =
                                                   
                                                   
                                                         skel.comprobarPlazas(wrappedParam)
                                                    ;
                                            
                                        envelope = toEnvelope(getSOAPFactory(msgContext), comprobarPlazasResponse11, false, new javax.xml.namespace.QName("http://www.example.org/Curso/",
                                                    "comprobarPlazas"));
                                    
            } else {
              throw new java.lang.RuntimeException("method not found");
            }
        

        newMsgContext.setEnvelope(envelope);
        }
        }
        catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
        }
        
        //
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.curso.ComprobarFecha param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.curso.ComprobarFecha.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.curso.ComprobarFechaResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.curso.ComprobarFechaResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.curso.ComprobarPlazas param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.curso.ComprobarPlazas.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
            private  org.apache.axiom.om.OMElement  toOM(org.example.www.curso.ComprobarPlazasResponse param, boolean optimizeContent)
            throws org.apache.axis2.AxisFault {

            
                        try{
                             return param.getOMElement(org.example.www.curso.ComprobarPlazasResponse.MY_QNAME,
                                          org.apache.axiom.om.OMAbstractFactory.getOMFactory());
                        } catch(org.apache.axis2.databinding.ADBException e){
                            throw org.apache.axis2.AxisFault.makeFault(e);
                        }
                    

            }
        
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.curso.ComprobarFechaResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.curso.ComprobarFechaResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.curso.ComprobarFechaResponse wrapComprobarFecha(){
                                org.example.www.curso.ComprobarFechaResponse wrappedElement = new org.example.www.curso.ComprobarFechaResponse();
                                return wrappedElement;
                         }
                    
                    private  org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory, org.example.www.curso.ComprobarPlazasResponse param, boolean optimizeContent, javax.xml.namespace.QName methodQName)
                        throws org.apache.axis2.AxisFault{
                      try{
                          org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();
                           
                                    emptyEnvelope.getBody().addChild(param.getOMElement(org.example.www.curso.ComprobarPlazasResponse.MY_QNAME,factory));
                                

                         return emptyEnvelope;
                    } catch(org.apache.axis2.databinding.ADBException e){
                        throw org.apache.axis2.AxisFault.makeFault(e);
                    }
                    }
                    
                         private org.example.www.curso.ComprobarPlazasResponse wrapComprobarPlazas(){
                                org.example.www.curso.ComprobarPlazasResponse wrappedElement = new org.example.www.curso.ComprobarPlazasResponse();
                                return wrappedElement;
                         }
                    


        /**
        *  get the default envelope
        */
        private org.apache.axiom.soap.SOAPEnvelope toEnvelope(org.apache.axiom.soap.SOAPFactory factory){
        return factory.getDefaultEnvelope();
        }


        private  java.lang.Object fromOM(
        org.apache.axiom.om.OMElement param,
        java.lang.Class type,
        java.util.Map extraNamespaces) throws org.apache.axis2.AxisFault{

        try {
        
                if (org.example.www.curso.ComprobarFecha.class.equals(type)){
                
                        return org.example.www.curso.ComprobarFecha.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.curso.ComprobarFechaResponse.class.equals(type)){
                
                        return org.example.www.curso.ComprobarFechaResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.curso.ComprobarPlazas.class.equals(type)){
                
                        return org.example.www.curso.ComprobarPlazas.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
                if (org.example.www.curso.ComprobarPlazasResponse.class.equals(type)){
                
                        return org.example.www.curso.ComprobarPlazasResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
                    

                }
            
        } catch (java.lang.Exception e) {
        throw org.apache.axis2.AxisFault.makeFault(e);
        }
           return null;
        }



    

        /**
        *  A utility method that copies the namepaces from the SOAPEnvelope
        */
        private java.util.Map getEnvelopeNamespaces(org.apache.axiom.soap.SOAPEnvelope env){
        java.util.Map returnMap = new java.util.HashMap();
        java.util.Iterator namespaceIterator = env.getAllDeclaredNamespaces();
        while (namespaceIterator.hasNext()) {
        org.apache.axiom.om.OMNamespace ns = (org.apache.axiom.om.OMNamespace) namespaceIterator.next();
        returnMap.put(ns.getPrefix(),ns.getNamespaceURI());
        }
        return returnMap;
        }

        private org.apache.axis2.AxisFault createAxisFault(java.lang.Exception e) {
        org.apache.axis2.AxisFault f;
        Throwable cause = e.getCause();
        if (cause != null) {
            f = new org.apache.axis2.AxisFault(e.getMessage(), cause);
        } else {
            f = new org.apache.axis2.AxisFault(e.getMessage());
        }

        return f;
    }

        }//end of class
    